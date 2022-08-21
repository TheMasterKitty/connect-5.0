using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_5._0
{
    public partial class GameNormal : Form
    {
        bool won = false;
        Graphics g;
        Chip[,] board;
        int[] bottom;
        Panel gameBoard;
        Pen p;
        Label turnLabel = new();
        PictureBox turnColor = new();
        Size map = new(7, 6);
        int winLength = 4;
        int turn = 0;
        int playerCount = 2;
        string[] playerNames = { "player1", "player2", "player3", "player4", "player5" };
        Color[] playerColors = new Color[0];
        bool fullscreen = true;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        internal void loadSettings(Size mapSize, int winRowLength, int players, string[] names, Color[] colors, bool fullScreen)
        {
            map = mapSize;
            winLength = winRowLength;
            playerCount = players;
            playerNames = names;
            playerColors = colors;
            fullscreen = fullScreen;
            board = new Chip[mapSize.Width, mapSize.Height];
            bottom = new int[map.Width];
        }
        public GameNormal()
        {
            InitializeComponent();
        }
        private async void Form_Load(object sender, EventArgs e)
        {
            won = false;
            gameBoard = new();
            if (fullscreen)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (map.Width < 10 && map.Height < 10)
            {
                Size = new(map.Width * 150, map.Height * 100);
            }
            else if (map.Width < 15 && map.Height < 15)
            {
                Size = new(map.Width * 120, map.Height * 80);
            }
            else
            {
                Size = new(map.Width * 60, map.Height * 40);
            }
            Location = new(Screen.FromControl(this).Bounds.Width / 2 - Width / 2, Screen.FromControl(this).Bounds.Height / 2 - Height / 2);
            gameBoard.Width = Convert.ToInt32(Size.Width * 0.75);
            gameBoard.Height = Convert.ToInt32(Size.Height * 0.8);
            gameBoard.Left = Convert.ToInt32(Size.Width * 0.15);
            gameBoard.Top = Convert.ToInt32(Size.Height * 0.1);
            gameBoard.BackColor = Color.Transparent;
            gameBoard.BorderStyle = BorderStyle.FixedSingle;
            gameBoard.Parent = this;
            turnLabel.Left = 0;
            turnLabel.Top = gameBoard.Top;
            turnLabel.Text = playerNames[turn];
            turnLabel.Parent = this;
            turnColor.Left = turnLabel.Width / 4 - 5;
            turnColor.Top = gameBoard.Top;
            turnColor.BackColor = playerColors[turn];
            turnColor.Width = turnLabel.Width / 4;
            turnColor.Height = turnLabel.Width / 2;
            turnColor.Parent = this;
            g = gameBoard.CreateGraphics();
            p = new Pen(Color.FromArgb(6, 8, 15), 3);
            for (int i = 0; i < map.Width; i++)
            {
                g.DrawLine(p, new(Convert.ToInt32(Math.Round((float)gameBoard.Width / map.Width)) * i, 0), new(Convert.ToInt32(Math.Round((float)gameBoard.Width / map.Width)) * i, gameBoard.Height));
                await Task.Delay(125);
            }
            for (int i = 1; i < map.Height + 1; i++)
            {
                g.DrawLine(p, new Point(0, Convert.ToInt32(Math.Round((float)gameBoard.Height / map.Height) * i)), new Point(gameBoard.Width, Convert.ToInt32(Math.Round((float)gameBoard.Height / map.Height)) * i));
                await Task.Delay(125);
            }
            gameBoard.MouseDown -= new MouseEventHandler(ClickToReset);
            gameBoard.MouseDown += new MouseEventHandler(GameBoardMouseDown);
            gameBoard.KeyDown += new KeyEventHandler(onKeyDownBLOCKER);
            while (!won)
            {
                for (int i = 1; i < playerCount + 1; i++)
                {
                    if (TestForWin(ChipGetter.GetChip(i)) != 0)
                    {
                        won = true;
                        g.FillRectangle(new SolidBrush(Color.LightGoldenrodYellow), new Rectangle(new(0, 0), new(gameBoard.Width, gameBoard.Height)));
                        await Task.Delay(200);
                        g.DrawString("Nice Job, " + playerNames[i - 1] + ", YOU WON!", new Font(FontFamily.GenericSerif, 32), new SolidBrush(Color.DarkSlateBlue), new Point(gameBoard.Width / 2 - TextRenderer.MeasureText("Nice Job, " + playerNames[turn] + ", YOU WON!", new Font(FontFamily.GenericSerif, 32)).Width / 2));
                        gameBoard.MouseDown -= new MouseEventHandler(GameBoardMouseDown);
                        gameBoard.MouseDown += new MouseEventHandler(ClickToReset);
                    }
                }
                await Task.Delay(50);
            }
        }
        private void onKeyDownBLOCKER(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = false;
        }
        private async void GameBoardMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Point start = new Point(Convert.ToInt32(e.X / (gameBoard.Width / map.Width)) * (gameBoard.Width / map.Width) + Convert.ToInt32(e.X / (gameBoard.Width / map.Width)), (gameBoard.Height - (((bottom[Convert.ToInt32(e.X / (gameBoard.Width / map.Width))]) * (gameBoard.Height / map.Height)) + (gameBoard.Height / map.Height))));
                g.FillRectangle(new SolidBrush(playerColors[turn]), new Rectangle(start, new Size(gameBoard.Width / map.Width + Convert.ToInt32(e.X / (gameBoard.Width / map.Width)) + 1 - Convert.ToInt32(Convert.ToInt32(e.X / (gameBoard.Width / map.Width)) / 2), gameBoard.Height / map.Height)));
                board[Convert.ToInt32(e.X / (gameBoard.Width / map.Width)), bottom[Convert.ToInt32(e.X / (gameBoard.Width / map.Width))]] = ChipGetter.GetChip(turn + 1);
                int x = Convert.ToInt32(e.X / (gameBoard.Width / map.Width));
                bottom[x]++;
                if (turn + 1 < playerCount)
                {
                    turn++;
                }
                else
                {
                    turn = 0;
                }
                turnLabel.Text = playerNames[turn];
                turnColor.BackColor = playerColors[turn];
                for (int i = 0; i < map.Width; i++)
                {
                    g.DrawLine(p, new(Convert.ToInt32(Math.Round((float)gameBoard.Width / map.Width)) * i, 0), new(Convert.ToInt32(Math.Round((float)gameBoard.Width / map.Width)) * i, gameBoard.Height));
                }
                for (int i = 1; i < map.Height + 1; i++)
                {
                    g.DrawLine(p, new Point(0, Convert.ToInt32(Math.Round((float)gameBoard.Height / map.Height) * i)), new Point(gameBoard.Width, Convert.ToInt32(Math.Round((float)gameBoard.Height / map.Height)) * i));
                }
            }
            catch { }
        }
        private void ClickToReset(object sender, MouseEventArgs e)
        {
            Form_Load(null, null);
        }
        private int TestForWin(Chip tileColor)
        {
            int count = 1;
            for (int c = 0; c < map.Width; c++)
            {
                for (int r = 0; r < map.Height; r++)
                {
                    if (board[c, r] == tileColor)
                    {
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c, r + i] == tileColor)
                                {
                                    count++;
                                    if (count == winLength)
                                    {
                                        return 1;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c, r - i] == tileColor)
                                {
                                    count++;
                                    if (count == winLength)
                                    {
                                        return 2;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c + i, r] == tileColor)
                                {
                                    count++;
                                if (count == winLength)
                                {
                                    return 3;
                                }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c - i, r] == tileColor)
                                {
                                    count++;
                                if (count == winLength)
                                {
                                    return 4;
                                }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c + i, r + i] == tileColor)
                                {
                                    count++;
                                if (count == winLength)
                                {
                                    return 5;
                                }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c - i, r + i] == tileColor)
                                {
                                    count++;
                                if (count == winLength)
                                {
                                    return 6;
                                }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c + i, r - i] == tileColor)
                                {
                                    count++;
                                if (count == winLength)
                                {
                                    return 7;
                                }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                        try
                        {
                            for (int i = 1; i < winLength; i++)
                            {
                                if (board[c - i, r - i] == tileColor)
                                {
                                    count++;
                                if (count == winLength)
                                {
                                    return 8;
                                }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch { }
                        count = 1;
                    }
                }
            }
            return 0;
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
                new Main().Show();
        }

        private void GameNormal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !fullscreen)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new GameNormal();
            x.loadSettings(map, winLength, playerCount, playerNames, playerColors, fullscreen);
            x.Show();
            Hide();
            Form_FormClosed(null, new FormClosedEventArgs(CloseReason.WindowsShutDown));
        }
    }
}
