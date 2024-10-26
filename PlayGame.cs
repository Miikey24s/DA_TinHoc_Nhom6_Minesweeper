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
    public partial class PlayGame : Form
    {
        public int capDoGame = 0;

        public PlayGame()
        {
            InitializeComponent();
        }
        public void VeBanCo()
        {
            MessageBox.Show("cap do game: " + capDoGame.ToString());
        }
        public int GetLevelGame()
        {
            return this.capDoGame;
        }
    }

}
