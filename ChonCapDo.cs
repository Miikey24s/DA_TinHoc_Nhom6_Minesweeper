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
        public int capDo = -1;
        public ChonCapDo()
        {
            InitializeComponent();
        }

        private void MoveForm()
        {
            this.Hide();
            PlayGame playGameDe = new PlayGame(capDo);
            playGameDe.ShowDialog();
            this.Close();
        }
        //chuyen sang giao dien choi game
        private void btnDe_Click(object sender, EventArgs e)
        {
            capDo = 0;
            MoveForm();

        }

        private void btnVua_Click(object sender, EventArgs e)
        {
            capDo = 1;
            MoveForm();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            capDo = 2;
            MoveForm();
        }

        private void ChonCapDo_Load(object sender, EventArgs e)
        {

        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu TrangChu = new TrangChu();
            TrangChu.ShowDialog();
            this.Close();
        }
    }
}
