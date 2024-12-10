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
        private string taiKhoan;
        public TrangChu(string taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
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
    }
}
