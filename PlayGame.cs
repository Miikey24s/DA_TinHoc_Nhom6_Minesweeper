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
        public PlayGame(int capDo)
        {
            InitializeComponent();
            VeBanCo(capDo);
        }

        public void VeBanCo(int capDo)
        {
            KichThuoc sizeBanCo = new KichThuoc();
            sizeBanCo.ChonSizeBanCo(capDo);
            int size = sizeBanCo.GetSizeBanCo();

            Bom bom = new Bom();
            int bombs = bom.GetBombs();

            Button oldButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new Button()
                    {
                        Width = KichThuoc.btnWidth,
                        Height = KichThuoc.btnHeight,
                        Location = new Point(
                        oldButton.Location.X + KichThuoc.btnWidth,
                        oldButton.Location.Y
                        )
                    };
                    this.Controls.Add(button);
                    oldButton = button;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + KichThuoc.btnHeight);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        public void CreateButton()
        {
            Button button = new Button()
            {
                Width = KichThuoc.btnWidth,
                Height = KichThuoc.btnHeight
            };
            this.Controls.Add(button);
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {

        }
    }

}
