using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.Http.Headers;
using DA_TinHoc_Nhom6_Minesweeper.PL;
using DA_TinHoc_Nhom6_Minesweeper.DAL;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public class NutMinVaCo : Button
    {
        //private string taiKhoan = "macDinh";
        private PlayGame playGame;
        public bool clicked = false;
        public bool isMin = false;
        public bool isFlagged = false;
        //private bool isOpen = false;
        public int countMinAround;
        public int trangThai = -1; // -1: trạng thái chưa mở, 0: là số, 1: là cờ
        public int d, c;
        public static NutMinVaCo[,] mangNut;
        public User user = new User();
        public ThangThuaGame thangThuaGame;
        
        public NutMinVaCo(int dong, int cot, PlayGame playGame, User user)
        {
            this.d = dong;
            this.c = cot;
            this.playGame = playGame;
            this.user = user;
            thangThuaGame = new ThangThuaGame(user);
            this.MouseClick += new MouseEventHandler(NutMin_MouseLeft);
            this.MouseDown += new MouseEventHandler(NutCo_MouseRight);
        }

        public void SoMin()
        {
            if (countMinAround > 0)
            {
                this.Text = countMinAround.ToString();
                clicked = true;
                this.BackColor = Color.White;
                this.ForeColor = ToMauChoSo(countMinAround);
                this.Font = new Font(this.Font.FontFamily, 15, FontStyle.Bold);
                this.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                KhongCoMin();
            }
        }
        public Color ToMauChoSo(int number)
        {
            switch (number)
            {
                case 1: return Color.Blue;
                case 2: return Color.Green;
                case 3: return Color.Red;
                case 4: return Color.Purple;
                case 5: return Color.Brown;
                case 6: return Color.Cyan;
                case 7: return Color.Black;
                case 8: return Color.Gray;
                default: return Color.LightGray;
            }
        }
        public void KhongCoMin()
        {
            //resume load lai mang ( co cac nut da clicked )
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

                    NutMinVaCo mangNutMoi = mangNut[newDong, newCot];
                    if (!mangNutMoi.clicked && !mangNutMoi.isFlagged)
                    {
                        mangNutMoi.Open(); // Gọi hàm Open để xử lý các ô kế bên
                    }
                }
            }
        }

        public void VeMinNo()
        {
            clicked = true;
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

        private void NutMin_MouseLeft(object sender, System.EventArgs e)
        {
            //if (!DemThoiGianChoi.BatDau) DemThoiGianChoi.StartTimer();

            // Kiểm tra nếu ô này là mìn
            if (isMin)
            {
                Open();
                MessageBox.Show("Trúng mìn rồi bạn ơi");
                thangThuaGame.ThuaTroChoi(playGame);
            }
            if (isFlagged == false)
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
            this.KiemTraChienThang();
        }

        public void KiemTraChienThang()
        {
            foreach (NutMinVaCo nut in mangNut)
            {
                if (!nut.clicked) return;// Da click het cac nut
            }
            thangThuaGame.ThangTroChoi(playGame);
        }

        private void NutCo_MouseRight(object sender, MouseEventArgs e)
        {
            if (trangThai == -1) return;
            if (e.Button == MouseButtons.Right)
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
        public void CamCo()
        {
            // Thêm hình ảnh cờ vào ô
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\flag.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }
        public void GoCo()
        {
            //Xóa hình ảnh cờ
            this.BackgroundImage = null;
        }
    }
}
