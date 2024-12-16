using DA_TinHoc_Nhom6_Minesweeper.BLL;
using DA_TinHoc_Nhom6_Minesweeper.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    public partial class ChonCapDo : Form
    {
        public int capDoResume = -1;

        public User user = new User();
        public PlayGame resumeGame;
        public ChonCapDo(User user)
        {
            this.InitializeComponent();
            this.user = user;
            
        }
        public void GetCapDo()
        {
            var capDo = LuuTienTrinhGamme.LoadCapDo(user.username);
            this.capDoResume = capDo;
        }
        public void ResumeGame(out PlayGame playGame)
        {
            string[] files = Directory.GetFiles(Application.StartupPath, $"{user.username}_Game_Save.txt");
            var (loadTime, capDo) = LuuTienTrinhGamme.LoadTienTrinhGame(user.username, user);
            this.capDoResume = capDo;
            playGame = LuuTienTrinhGamme.LoadMangNut(user.username);


            LoadResumeGame(ref playGame);
            playGame.isPaused = false;
            playGame.demtg.StartTimer();


            playGame.HienThiMin();
        }
        public void LoadResumeGame(ref PlayGame playGame)
        {
            for (int i = 0; i < playGame.MangNut.GetLength(0); i++)
            {
                for (int j = 0; j < playGame.MangNut.GetLength(1); j++)
                {
                    if (playGame.MangNut[i, j].clicked && playGame.MangNut[i, j].isMin == false)
                    {
                        playGame.MangNut[i, j].SoMin();
                        playGame.MangNut[i, j].VeNutKhongCoMin();
                    }
                    if (playGame.MangNut[i, j].isFlagged)
                    {
                        playGame.MangNut[i, j].CamCo();
                    }
                }
            }

        }
        private void MoveToPlayGame(int capDo)
        {
            this.Hide();
            PlayGame playGame = new PlayGame(user.username, capDo);
            playGame.ShowDialog();
            this.Close();

            
        }
        
        private void MoveToMainMenu()
        {
            this.Hide();
            TrangChu TrangChu = new TrangChu(user);
            TrangChu.ShowDialog();
            this.Close();
        }
        //chuyen sang giao dien choi game
        private void btnDe_Click(object sender, EventArgs e)
        {
            this.MoveToPlayGame(0);
        }

        private void btnVua_Click(object sender, EventArgs e)
        {
            this.MoveToPlayGame(1);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            this.MoveToPlayGame(2);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.MoveToMainMenu();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {

            //if (this.capDoResume == -1) return;
            this.Hide();
            GetCapDo();
            GameLogic.resumeBom = true;
            resumeGame = new PlayGame(user.username, this.capDoResume);
            ResumeGame(out resumeGame);
            resumeGame.ShowDialog();
            this.Close();

        }
    }
}
