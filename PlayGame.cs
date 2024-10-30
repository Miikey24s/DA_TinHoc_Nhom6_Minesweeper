using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper
{
    public partial class PlayGame : Form
    {
        public int isCo = 0;
        private int capDo;
        private int soCo;
        
        public PlayGame(int capDo)
        {
            InitializeComponent();
            this.capDo = capDo;
            this.soCo = this.GetFlag();
            VeBanCo();
        }

        public void VeBanCo()
        {
            VeOCo();
            VeFlag();
        }

        public void VeFlag()
        {
            lblSoCo.Text = this.soCo.ToString();
        }

        public int GetFlag()
        {
            return this.GetSizeBomb(); ;
        }

        public int GetSizeBanCo()
        {
            // lay kich thuoc ban co theo cap do
            KichThuoc sizeBanCo = new KichThuoc();
            sizeBanCo.ChonSizeBanCo(this.capDo);
            return sizeBanCo.GetSizeBanCo();
        }

        public int GetSizeBomb()
        {
            // lay so bom theo cap do
            Bom bom = new Bom();
            bom.ChonSoBombs(this.capDo);
            return bom.GetBombs();
        }

        public Button CreateOldButton()
        {
            Button oldButton = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            return oldButton;
        }

        public void UpdateOldButton(ref Button oldButton)
        {
            oldButton.Location = new Point(0, oldButton.Location.Y + KichThuoc.btnHeight);
            oldButton.Width = 0;
            oldButton.Height = 0;
        }

        public void CreateButton(ref Button oldButton)
        {
            Button button = new Button()
            {
                Width = KichThuoc.btnWidth,
                Height = KichThuoc.btnHeight,
                Location = new Point(
                        oldButton.Location.X + KichThuoc.btnWidth,
                        oldButton.Location.Y
                        ),
                BackgroundImageLayout = ImageLayout.Zoom
            };

            button.Click += Button_Click_Handler;
            this.Controls.Add(button);
            oldButton = button;
        }

        private void Button_Click_Handler(object sender, EventArgs e)
        {
            if(soCo > 0)
            {
                if (isCo == 1)
                {
                    button_Click(sender, e);
                    soCo--;
                    VeFlag();
                }
            }
        }

        public void VeOCo()
        {
            Button oldButton = this.CreateOldButton();

            for (int i = 0; i < this.GetSizeBanCo() - 1; i++)
            {
                for (int j = 0; j < this.GetSizeBanCo(); j++)
                {
                    CreateButton(ref oldButton);
                }
                UpdateOldButton(ref oldButton);
            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button buttonFlag = sender as Button;
            buttonFlag.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\flag.png");
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            isCo = isCo == 1 ? 0 : 1;
        }
    }

}
