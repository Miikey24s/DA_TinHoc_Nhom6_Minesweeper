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
        ChonCapDo chonCapDo = new ChonCapDo();
        KichThuoc sizeBanCo = new KichThuoc();
        Bom bom = new Bom();
        public NutMin[,] MangNut;
        public int capDo;

        public PlayGame(int capDo)
        {
            InitializeComponent();
            this.capDo = capDo;
            VeBanCo();
        }
        public void VeBanCo()
        {
            VeOCo();
            DatMinNgauNhien();
            DemMinXungQuanh();
        }

        public int GetSizeBanCo()
        {
            // lay kich thuoc ban co theo cap do
            sizeBanCo.ChonSizeBanCo(this.capDo);
            return sizeBanCo.GetSizeBanCo();
        }

        public int GetSizeBomb()
        {
            // lay so bom theo cap do
            bom.ChonSoBombs(this.capDo);
            return bom.GetBombs();
        }
        public void CreateButton(int i, int j)
        {
            MangNut[i, j] = new NutMin(i, j)
            {
                trangThai = 0,
                Location = new System.Drawing.Point(i * 30, j * 30),
                Size = new System.Drawing.Size(30, 30)
            };
            this.Controls.Add(MangNut[i, j]);
        }

        public void VeOCo()
        {
            MangNut = new NutMin[this.GetSizeBanCo(), this.GetSizeBanCo()];
            NutMin.mangNut = MangNut;
            for (int i = 0; i < this.GetSizeBanCo(); i++)
            {
                for (int j = 0; j < this.GetSizeBanCo(); j++)
                {
                    CreateButton(i, j);
                }
            }
        }
        public void DatMinNgauNhien()
        {
            int count = 0;
            while (count < GetSizeBomb())
            {
                int index = new Random().Next(GetSizeBanCo() * GetSizeBanCo());
                int r = index / GetSizeBanCo();
                int c = index % GetSizeBanCo();

                if (!MangNut[r, c].isMin)
                {
                    MangNut[r, c].isMin = true;
                    count++;
                }
            }
        }
        public void DemMinXungQuanh()
        {
            for (int i = 0; i < this.GetSizeBanCo(); i++)
            {
                for (int j = 0; j < this.GetSizeBanCo(); j++)
                {
                    int count = 0;
                    for (int x = i - 1; x <= i + 1; x++)
                        for (int y = j - 1; y <= j + 1; y++)
                            if ((x < GetSizeBanCo() & y < GetSizeBanCo()) & (x >= 0 & y >= 0) & !(x == i & y == j))
                                if (MangNut[x, y].isMin)
                                    count++;
                    MangNut[i, j].countMinAround = count;
                }
            }
        }
    }
}
