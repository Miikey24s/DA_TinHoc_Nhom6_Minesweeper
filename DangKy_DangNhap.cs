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
using static DA_TinHoc_Nhom6_Minesweeper.DangKy_DangNhap;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public partial class DangKy_DangNhap : Form
    {
        private string dataTK = "DanhSachh.txt";
        private string TGDangNhap = "ThoiGianChoi.txt";
        private string taiKhoan;
        public DangKy_DangNhap()
        {
            InitializeComponent();
            this.taiKhoan = txtTaiKhoan.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKhách_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu(taiKhoan);
            trangChu.ShowDialog();
            this.Close();
        }

        private bool ghifile(User user)
        {
            try
            {
                FileStream fs = new FileStream(dataTK,FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"{user.TaiKhoan},{user.MatKhau}");
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        private List<User> docFile()
        {
            {
                List<User> userList = new List<User>();
                FileStream fs = null;
                try
                {
                    fs = new FileStream(dataTK, FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(fs);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            User user = new User { TaiKhoan = parts[0], MatKhau = parts[1] };
                            userList.Add(user);
                        }
                    }
                    sr.Close();
                    fs.Close();
                    return userList;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool flag = false;
            List<User> list = docFile();
            bool tontai = false;
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (txtTaiKhoan.Text != "")
                {
                    if (list != null)
                    {
                        foreach (User user in list)
                        {
                            if (user.TaiKhoan == txtTaiKhoan.Text)
                            {
                                tontai = true;
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (tontai)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTaiKhoan.Text = "";
                        txtMatKhau.Text = "";
                    }
                    else
                    {
                        User user = new User
                        {
                            TaiKhoan = txtTaiKhoan.Text,
                            MatKhau = txtMatKhau.Text
                        };
                        flag = true;
                        tontai = false;
                        txtTaiKhoan.Text = "";
                        txtMatKhau.Text = "";

                        if (ghifile(user))
                            MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("KHÔNG THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool tontai = false;
            List<User> userList = docFile();
            if (txtTaiKhoan.Text != "")
            {
                if (userList != null)
                {
                    foreach (User user in userList)
                    {
                        if (user.TaiKhoan == txtTaiKhoan.Text && user.MatKhau != txtMatKhau.Text)
                        {
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMatKhau.Text = "";
                            tontai = true;
                            break;

                        }

                    }
                }
            }
            if (userList != null)
            {
                bool flag = false;
                foreach (User user in userList)
                {
                    if (user.TaiKhoan == txtTaiKhoan.Text && user.MatKhau == txtMatKhau.Text)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    TrangChu trangChu = new TrangChu(txtTaiKhoan.Text);
                    trangChu.ShowDialog();
                    this.Close();
                }
                else if(tontai == false)
                    MessageBox.Show("Tài khoản không tồn tại.\nSai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Không thể đọc danh sách tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GhiThoiGianDangNhap(string taiKhoan)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(TGDangNhap, true))
                {
                    sw.WriteLine($"{taiKhoan},{DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi log thời gian chơi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        [Serializable]
        public class User
        {
            public string TaiKhoan { get; set; }
            public string MatKhau { get; set; }
        }
    }
}
