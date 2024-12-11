using DA_TinHoc_Nhom6_Minesweeper.DAL;
using DA_TinHoc_Nhom6_Minesweeper.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public class ThangThuaGame
    {
        private User user = new User();
        public ThangThuaGame(User user)
        {
            this.user = user;
        }
        public ThangThuaGame()
        {

        }
        public void MoveToPlayGameAgain(DialogResult result, Form form)
        {
            if (result == DialogResult.Yes)
            {
                form.Hide();
                new ChonCapDo(user).ShowDialog();  //Chơi lại
                form.Close();
            }
            else
            {
                Application.Exit();  //Thoát
            }
        }
        public void ThangTroChoi(Form form)
        {
            DialogResult result;
            //DemThoiGianChoi.StopTimer();
            MessageBox.Show("Bạn đã thắng!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result = MessageBox.Show("Bạn có muốn chơi lại không?", "Trò chơi đã thắng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MoveToPlayGameAgain(result, form);
        }

        public void ThuaTroChoi(Form form)
        {
            DialogResult result;
            //t.Stop();
            result = MessageBox.Show("Bạn có muốn chơi lại không?", "Chinh phục lại nào!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MoveToPlayGameAgain(result, form);
        }
    }
}
