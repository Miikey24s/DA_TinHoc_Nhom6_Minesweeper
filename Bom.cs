using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public class Bom
    {
        public int bom;
        public void ChonSoBombs(int capDo)
        {
            switch (capDo)
            {
                case 0:
                    this.bom = 10;
                    break;
                case 1:
                    this.bom = 40;
                    break;
                case 2:
                    this.bom = 99;
                    break;
                default:
                    break;
            }
        }
        public int GetBombs()
        {
            return this.bom;
        }
    } 
}
