using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChonCapDo chonCapDo = new ChonCapDo();
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
        private void playerName_Click(object sender, EventArgs e)
        {
            DangKy_DangNhap dky_dn = new DangKy_DangNhap();
            DialogResult result = MessageBox.Show("Bạn có muốn đăng ký tài khoản không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //playerName.Text = dky_dn;
                this.Hide();
                dky_dn.ShowDialog();
                this.Close();
            }
        }
    }
}
