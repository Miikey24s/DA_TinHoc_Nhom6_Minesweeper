using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public class NutCo : Button 
    {
        public bool clicked = false;
        public bool isMin = false;
        public bool coFlag=false;
        public int countMinAround;
        public int trangThai = -1;
        public int d, c;
        public static NutCo[,] mangNut;
        public NutCo(int dong, int cot)
        {
            this.d = dong;
            this.c = cot;
            this.MouseUp += new MouseEventHandler(NutCo_MouseUp);
        }
        private void NutCo_MouseUp(object sender, System.EventArgs e)
        {

        }

    


    }
}
