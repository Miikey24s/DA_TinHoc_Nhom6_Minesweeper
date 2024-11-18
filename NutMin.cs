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
        public bool isFlagged = false;
        private bool isOpen = false;
        public int countMinAround;
        public int trangThai = -1; // -1: trạng thái mặc định, 0: là số, 1: là cờ
        public int d, c;
        public static NutMin[,] mangNut;

        public NutMin(int dong, int cot)
        {
            this.d = dong;
            this.c = cot;
            this.MouseClick += new MouseEventHandler(NutMin_MouseClick); 
            this.MouseDown += new MouseEventHandler(NutMin_MouseDown);   
        }

        public void SoMin()
        {
            if (countMinAround > 0)
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
            if (clicked == true || countMinAround > 0) return;
            clicked = true;
            this.BackColor = Color.Gray;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newDong = d + i;
                    int newCot = c + j;
                    if (newDong < 0) continue;
                    if (newCot < 0) continue;
                    if (newDong >= mangNut.GetLength(0)) continue;
                    if (newCot >= mangNut.GetLength(1)) continue;

                    NutMin mangNutMoi = mangNut[newDong, newCot];
                    if (mangNutMoi.clicked || mangNutMoi.isMin) continue;
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
            if (isOpen)
            {
                return;
            }
            trangThai = -1;
            if (isMin) VeMinNo();
            else
            {
                SoMin();
            }
        }

        private void NutMin_MouseClick(object sender, System.EventArgs e)
        {
            // Xử lý chuột trái (click)
            if (e is MouseEventArgs me && me.Button == MouseButtons.Left)
            {
                switch (trangThai)
                {
                    case -1:
                        break;
                    case 0:
                        Open();
                        break;

                }
            }
        }

        private void NutMin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!isFlagged)
                {
                    CamCo();
                    isFlagged = true;
                }
                else
                {
                    GoCo();
                    isFlagged = false;
                }
            }
        }
        public void CamCo()
        {
            // Thêm hình ảnh cờ vào ô
            //this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\flag.png");
            //this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Text = "F";
        }

        public void GoCo()
        {
            // Xóa hình ảnh cờ
            //this.BackgroundImage = null;
            this.Text = "";
        }
    }

}
