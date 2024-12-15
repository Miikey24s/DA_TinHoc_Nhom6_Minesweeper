using DA_TinHoc_Nhom6_Minesweeper.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    public partial class TrangChu : Form
    {
        //public DangKy_DangNhap DangKy_DangNhap = new DangKy_DangNhap();
        public User user = new User();
        public TrangChu(User user)
        {
            InitializeComponent();
            this.user = user;
            if (this.user.username == "" || this.user.username == null)
            {
                this.user.username = "Khách";
            }
            lblPlayerName.Text = this.user.username;
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChonCapDo chonCapDo = new ChonCapDo(user);
            chonCapDo.ShowDialog();
            this.Close();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hướng dẫn chơi DÒ MÌN ĐÊ!!!:\n" +
                             "- Mục tiêu: Dò ra số mìn có trong ô.\n" +
                             "- Cách chơi:\n" +
                             "  * Click trái: Phá ô dò mìn.\n" +
                             "  * Click phải: Đánh dấu mìn bằng cờ đỏ.\n" +
                             "- Quy tắc:\n" +
                             "  * Tính toán để cho không dẫm vào mìn.\n" +
                             "  * Hãy nhìn vào các con số hiện lên để biết ở đâu có mìn nhé!\n" +
                             "  * Phá đảo tất cả các ô không dẫm phải mìn để thắng.", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MoveToLogin()
        {
            this.Hide();
            DangKy_DangNhap dangKy_DangNhap = new DangKy_DangNhap();
            dangKy_DangNhap.ShowDialog();
            this.Close();
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            //DemThoiGianChoi.StopTimer();
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MoveToLogin();
            }
        }
    }
}
