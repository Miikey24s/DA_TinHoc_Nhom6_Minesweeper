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
    public class NutMin : Button
    {
        public bool clicked = false;
        public bool isMin = false;
        public int countMinAround;
        public int trangThai = -1; 
        public int d, c;
        public static NutMin[,] mangNut;
        
        public NutMin(int dong, int cot)
        {
            this.d = dong;
            this.c = cot;
            
            this.MouseClick += new MouseEventHandler(NutMin_MouseClick);
        }
        public void SoMin()
        {
            if(countMinAround > 0)
            {
                this.Text = countMinAround.ToString();
                clicked = true;
            }
            else
            {
                KhongCoMin();
            }
        }
        public void KhongCoMin()
        {
            if (clicked || countMinAround > 0) return;

            clicked = true;
            this.BackColor = Color.LightGray;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newDong = d + i;
                    int newCot = c + j;

                    // Kiểm tra biên của mảng
                    if (newDong < 0 || newDong >= mangNut.GetLength(0) ||
                        newCot < 0 || newCot >= mangNut.GetLength(1)) continue;

                    NutMin mangNutMoi = mangNut[newDong, newCot];

                    // Bỏ qua ô đã mở hoặc là ô có mìn
                    if (mangNutMoi.clicked || mangNutMoi.isMin) continue;

                    // Đệ quy gọi hàm KhongCoMin cho ô tiếp theo
                    mangNutMoi.KhongCoMin();
                }
            }
        }

        public void VeMinNo()
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\bomb.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
        public void Open()
        {
            trangThai = -1;
            if (isMin) VeMinNo();
            else
            {
                SoMin();
            }
        }
        private void NutMin_MouseClick(object sender, System.EventArgs e)
        {
            //-1: trang thai mac dinh, 0: la so, 1: la co
            switch (trangThai)
            {
                case -1:
                    break;
                case 0:
                    Open();
                    break;
                case 1:
                    //
                    break;
            }
        }
    }
}
