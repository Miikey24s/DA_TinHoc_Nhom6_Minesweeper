using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public partial class ChonCapDo : Form
    {
        public ChonCapDo()
        {
            InitializeComponent();
        }
        //chuyen sang giao dien choi game
        private void btnDe_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayGame playGameDe = new PlayGame();
            playGameDe.ShowDialog();
            playGameDe.capDoGame = 1;

            this.Close();
        }

        private void btnVua_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayGame playGameDe = new PlayGame();
            playGameDe.ShowDialog();
            playGameDe.capDoGame = 2;

            this.Close();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayGame playGameDe = new PlayGame();
            playGameDe.ShowDialog();
            playGameDe.capDoGame = 3;

            this.Close();
        }
    }
}
