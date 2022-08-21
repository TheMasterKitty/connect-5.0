namespace Connect_5._0
{
    public partial class Main : Form
    {
        private int gameSelection = 0;
        private bool numberSelectLocked = false;
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSelection = 1;
            panel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameSelection = 2;
            panel1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameSelection = 3;
            panel1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (numberSelectLocked)
            {
                button5.BackgroundImage = Properties.Resources.Unlocked;
                numberSelectLocked = !numberSelectLocked;
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.Locked;
                numberSelectLocked = !numberSelectLocked;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numberSelectLocked)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numberSelectLocked)
            {
                numericUpDown1.Value = numericUpDown2.Value;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value == 2)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
            }
            else if (numericUpDown4.Value == 3)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
            }
            else if (numericUpDown4.Value == 4)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
                button25.Enabled = true;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
                button30.Enabled = false;
            }
            else if (numericUpDown4.Value == 5)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
                button25.Enabled = true;
                button26.Enabled = true;
                button27.Enabled = true;
                button28.Enabled = true;
                button29.Enabled = true;
                button30.Enabled = true;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Color[] colors = new Color[5];
            if (button6.FlatAppearance.BorderSize == 3)
            {
                colors[0] = button6.BackColor;
            }
            if (button7.FlatAppearance.BorderSize == 3)
            {
                colors[0] = button7.BackColor;
            }
            if (button8.FlatAppearance.BorderSize == 3)
            {
                colors[0] = button8.BackColor;
            }
            if (button9.FlatAppearance.BorderSize == 3)
            {
                colors[0] = button9.BackColor;
            }
            if (button10.FlatAppearance.BorderSize == 3)
            {
                colors[0] = button10.BackColor;
            }
            if (button11.FlatAppearance.BorderSize == 3)
            {
                colors[1] = button11.BackColor;
            }
            if (button12.FlatAppearance.BorderSize == 3)
            {
                colors[1] = button12.BackColor;
            }
            if (button13.FlatAppearance.BorderSize == 3)
            {
                colors[1] = button13.BackColor;
            }
            if (button14.FlatAppearance.BorderSize == 3)
            {
                colors[1] = button14.BackColor;
            }
            if (button15.FlatAppearance.BorderSize == 3)
            {
                colors[1] = button15.BackColor;
            }
            if (button16.FlatAppearance.BorderSize == 3)
            {
                colors[2] = button16.BackColor;
            }
            if (button17.FlatAppearance.BorderSize == 3)
            {
                colors[2] = button17.BackColor;
            }
            if (button18.FlatAppearance.BorderSize == 3)
            {
                colors[2] = button18.BackColor;
            }
            if (button19.FlatAppearance.BorderSize == 3)
            {
                colors[2] = button19.BackColor;
            }
            if (button20.FlatAppearance.BorderSize == 3)
            {
                colors[2] = button20.BackColor;
            }
            if (button21.FlatAppearance.BorderSize == 3)
            {
                colors[3] = button21.BackColor;
            }
            if (button22.FlatAppearance.BorderSize == 3)
            {
                colors[3] = button22.BackColor;
            }
            if (button23.FlatAppearance.BorderSize == 3)
            {
                colors[3] = button23.BackColor;
            }
            if (button24.FlatAppearance.BorderSize == 3)
            {
                colors[3] = button24.BackColor;
            }
            if (button25.FlatAppearance.BorderSize == 3)
            {
                colors[3] = button25.BackColor;
            }
            if (button26.FlatAppearance.BorderSize == 3)
            {
                colors[4] = button26.BackColor;
            }
            if (button27.FlatAppearance.BorderSize == 3)
            {
                colors[4] = button27.BackColor;
            }
            if (button28.FlatAppearance.BorderSize == 3)
            {
                colors[4] = button28.BackColor;
            }
            if (button29.FlatAppearance.BorderSize == 3)
            {
                colors[4] = button29.BackColor;
            }
            if (button30.FlatAppearance.BorderSize == 3)
            {
                colors[4] = button30.BackColor;
            }
            if (gameSelection == 1)
            {
                GameNormal gN = new();
                gN.loadSettings(new((int)numericUpDown1.Value, (int)numericUpDown2.Value), (int)numericUpDown3.Value, (int)numericUpDown4.Value, new[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text}, colors, checkBox3.Checked);
                gN.Show();
            }
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 3;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 3;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 3;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 3;
            button10.FlatAppearance.BorderSize = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.BorderSize = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.BorderSize = 3;
            button15.FlatAppearance.BorderSize = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.BorderSize = 3;
            button14.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.BorderSize = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 3;
            button13.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.BorderSize = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 3;
            button12.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.BorderSize = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.BorderSize = 3;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.BorderSize = 3;
            button20.FlatAppearance.BorderSize = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.BorderSize = 3;
            button19.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.BorderSize = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.BorderSize = 3;
            button18.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.BorderSize = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 3;
            button17.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.BorderSize = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button21.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.BorderSize = 0;
            button23.FlatAppearance.BorderSize = 0;
            button24.FlatAppearance.BorderSize = 0;
            button25.FlatAppearance.BorderSize = 3;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button21.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.BorderSize = 0;
            button23.FlatAppearance.BorderSize = 0;
            button24.FlatAppearance.BorderSize = 3;
            button25.FlatAppearance.BorderSize = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button21.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.BorderSize = 0;
            button23.FlatAppearance.BorderSize = 3;
            button24.FlatAppearance.BorderSize = 0;
            button25.FlatAppearance.BorderSize = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {

            button21.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.BorderSize = 3;
            button23.FlatAppearance.BorderSize = 0;
            button24.FlatAppearance.BorderSize = 0;
            button25.FlatAppearance.BorderSize = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.FlatAppearance.BorderSize = 3;
            button22.FlatAppearance.BorderSize = 0;
            button23.FlatAppearance.BorderSize = 0;
            button24.FlatAppearance.BorderSize = 0;
            button25.FlatAppearance.BorderSize = 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button26.FlatAppearance.BorderSize = 0;
            button27.FlatAppearance.BorderSize = 0;
            button28.FlatAppearance.BorderSize = 0;
            button29.FlatAppearance.BorderSize = 0;
            button30.FlatAppearance.BorderSize = 3;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button26.FlatAppearance.BorderSize = 0;
            button27.FlatAppearance.BorderSize = 0;
            button28.FlatAppearance.BorderSize = 0;
            button29.FlatAppearance.BorderSize = 3;
            button30.FlatAppearance.BorderSize = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button26.FlatAppearance.BorderSize = 0;
            button27.FlatAppearance.BorderSize = 0;
            button28.FlatAppearance.BorderSize = 3;
            button29.FlatAppearance.BorderSize = 0;
            button30.FlatAppearance.BorderSize = 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button26.FlatAppearance.BorderSize = 0;
            button27.FlatAppearance.BorderSize = 3;
            button28.FlatAppearance.BorderSize = 0;
            button29.FlatAppearance.BorderSize = 0;
            button30.FlatAppearance.BorderSize = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.FlatAppearance.BorderSize = 3;
            button27.FlatAppearance.BorderSize = 0;
            button28.FlatAppearance.BorderSize = 0;
            button29.FlatAppearance.BorderSize = 0;
            button30.FlatAppearance.BorderSize = 0;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Size = new(800, 650);
        }
    }
}