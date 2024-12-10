using DA_TinHoc_Nhom6_Minesweeper.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public static class ThangThuaGame
    {
        public static void ThangTroChoi(Form form)
        {
            DialogResult result;
            DemThoiGianChoi.StopTimer();
            MessageBox.Show("Bạn đã thắng!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result = MessageBox.Show("Bạn có muốn chơi lại không?", "Trò chơi đã thắng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                form.Hide();
                new ChonCapDo().ShowDialog();  //Chơi lại
                form.Close();
            }
            else
            {
                Application.Exit();  //Thoát
            }
        }

        public static void ThuaTroChoi(Form form)
        {
            DialogResult result;
            //t.Stop();

            MessageBox.Show("Bạn đã thua!", "Đáng tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result = MessageBox.Show("Bạn có muốn chơi lại không?", "Chinh phục lại nào!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                form.Hide();
                new ChonCapDo().ShowDialog();  //Chơi lại
                form.Close();
            }
            else
            {
                Application.Exit();  //Thoát
            }
        }
    }
}
