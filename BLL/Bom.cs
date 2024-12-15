using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public class Bom
    {
        public int bomCount;
        public void ChonSoBombs(int capDo)
        {
            switch (capDo)
            {
                case 0:
                    this.bomCount = 10;
                    break;
                case 1:
                    this.bomCount = 40;
                    break;
                case 2:
                    this.bomCount = 99;
                    break;
                default:
                    break;
            }
        }
        public int GetBombs()
        {
            return this.bomCount;
        }
    } 
}
