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
        public int capDo = 0;
        public ChonCapDo()
        {
            InitializeComponent();
        }

        private void MoveForm()
        {
            this.Hide();
            Bom bom = new Bom();
            bom.ChonSoBombs(capDo);

            KichThuoc sizeBanCo = new KichThuoc();
            sizeBanCo.ChonSizeBanCo(capDo);

            PlayGame playGameDe = new PlayGame();
            playGameDe.ShowDialog();
            this.Close();
        }
        //chuyen sang giao dien choi game
        private void btnDe_Click(object sender, EventArgs e)
        {
            capDo = 1;
            MoveForm();
            //this.Hide();
            //Bom bom = new Bom();
            //bom.GetBombs(capDo);

            //Size sizeBanCo = new Size();
            //sizeBanCo.GetSizeBanCo(capDo);

            //PlayGame playGameDe = new PlayGame();
            //playGameDe.ShowDialog();
            //this.Close();
        }

        private void btnVua_Click(object sender, EventArgs e)
        {
            //capDo = 2;

            //this.Hide();
            //PlayGame playGameDe = new PlayGame();
            //Bom bom = new Bom();
            //bom.GetBombs(capDo);
            //playGameDe.ShowDialog();
            //this.Close();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            //capDo = 3;

            //this.Hide();
            //PlayGame playGameDe = new PlayGame();
            //Bom bom = new Bom();
            //bom.GetBombs(capDo);
            //playGameDe.ShowDialog();
            //this.Close();
        }

        private void ChonCapDo_Load(object sender, EventArgs e)
        {

        }
    }
}
