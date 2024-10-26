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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
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

        }
    }
}
