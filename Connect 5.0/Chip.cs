using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_5._0
{
    enum Chip
    {
        EMPTY = 0,
        P1 = 1,
        P2 = 2,
        P3 = 3,
        P4 = 4,
        P5 = 5,
    }
    internal class ChipGetter
    {
        internal static Chip GetChip(int pN)
        {
            if (pN == 0)
            {
                return Chip.EMPTY;
            }
            else if (pN == 1)
            {
                return Chip.P1;
            }
            else if (pN == 2)
            {
                return Chip.P2;
            }
            else if (pN == 3)
            {
                return Chip.P3;
            }
            else if (pN == 4)
            {
                return Chip.P4;
            }
            else if (pN == 5)
            {
                return Chip.P5;
            }
            else
            {
                return Chip.EMPTY;
            }
        }
    }
}
