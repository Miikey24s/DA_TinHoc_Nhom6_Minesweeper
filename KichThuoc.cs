using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public class KichThuoc
    {
        public int sizeBanCo;
        public static int btnWidth = 50;
        public static int btnHeight = 50;
        public void ChonSizeBanCo(int capDo)
        {
            switch (capDo)
            {
                case 0:
                    this.sizeBanCo = 9;
                    break;
                case 1:
                    this.sizeBanCo = 16;
                    break;
                case 2:
                    this.sizeBanCo = 24;
                    break;
                default:
                    break;
            }
        }
        public int GetSizeBanCo()
        {
            return this.sizeBanCo;
        }
    }
}
