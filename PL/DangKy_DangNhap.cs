using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics.Eventing.Reader;
using DA_TinHoc_Nhom6_Minesweeper.DAL;

namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    public partial class DangKy_DangNhap : Form
    {
        //private string dataTK = "DanhSachh.txt";
        //private string TGDangNhap = "ThoiGianChoi.txt";
        //private string taiKhoan;
        private readonly User user = new User();
        public DangKy_DangNhap()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKhách_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu(user);
            trangChu.ShowDialog();
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //bool flag = false;

            KhoiTaoUserData();

            if (this.user.AddUser(this.user.username, this.user.password))
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void KhoiTaoUserData()
        {
            this.user.username = txtTaiKhoan.Text.Trim();
            this.user.password = txtMatKhau.Text.Trim();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KhoiTaoUserData();

            if (this.user.ValidateUser(this.user.username, this.user.password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TrangChu mainMenu = new TrangChu(user);
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
        }
    }
}
