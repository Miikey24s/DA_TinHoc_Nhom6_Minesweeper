using DA_TinHoc_Nhom6_Minesweeper.DAL;
using DA_TinHoc_Nhom6_Minesweeper.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public class ThangThuaGame
    {
        private readonly User user = new User();
        public ChonCapDo chonCapDo;
        public ThangThuaGame(User user, ChonCapDo chonCapDo)
        {
            this.user = user;
            this.chonCapDo = chonCapDo;
        }
        public ThangThuaGame()
        {

        }
        public void MoveToPlayGameAgain(DialogResult result, PlayGame playGame)
        {
            ChonCapDo.isWinOrLose = true;
            if (result == DialogResult.Yes)
            {
                playGame.Hide();
                chonCapDo.RemoveButtonResume();
                DemThoiGianChoi.isResume = false;
                GameLogic.resumeBom = false;
                chonCapDo.Show();  //Chơi lại
                playGame.Close();
            }
            else
            {
                Application.Exit();  //Thoát
            }
        }
        public void ThangTroChoi(PlayGame playGame)
        {
            
            DialogResult result;
            //DemThoiGianChoi.StopTimer();
            MessageBox.Show("Bạn đã thắng!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result = MessageBox.Show("Bạn có muốn chơi lại không?", "Trò chơi đã thắng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MoveToPlayGameAgain(result, playGame);
        }

        public void ThuaTroChoi(PlayGame playGame)
        {
            DialogResult result;
            //t.Stop();
            result = MessageBox.Show("Bạn có muốn chơi lại không?", "Chinh phục lại nào!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MoveToPlayGameAgain(result, playGame);
        }
    }
}
