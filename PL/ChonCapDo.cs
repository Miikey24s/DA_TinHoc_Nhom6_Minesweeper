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
    public partial class ChonCapDo : Form
    {
        //public int capDo = -1;
        
        public User user = new User();
        public ChonCapDo()
        {
            this.InitializeComponent();
           
        }

        private void MoveToPlayGame(int capDo)
        {
            this.Hide();
            PlayGame playGame = new PlayGame(user.TaiKhoan, capDo);
            playGame.ShowDialog();
            this.Close();
        }
        
        private void MoveToMainMenu()
        {
            this.Hide();
            TrangChu TrangChu = new TrangChu(user.TaiKhoan);
            TrangChu.ShowDialog();
            this.Close();
        }
        //chuyen sang giao dien choi game
        private void btnDe_Click(object sender, EventArgs e)
        {
            //this.capDo = 0;
            this.MoveToPlayGame(0);
        }

        private void btnVua_Click(object sender, EventArgs e)
        {
            //this.capDo = 1;
            this.MoveToPlayGame(1);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            //this.capDo = 2;
            this.MoveToPlayGame(2);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.MoveToMainMenu();
        }
    }
}
