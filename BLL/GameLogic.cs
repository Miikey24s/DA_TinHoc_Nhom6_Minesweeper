using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_TinHoc_Nhom6_Minesweeper.PL;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public class GameLogic
    {
        //System.Timers.Timer t = new System.Timers.Timer();
        //public string TKDangChoi { get; }
        //public int h, m, s;
        //public bool BatDau = false;
        //ChonCapDo chonCapDo;
        QuanLyCapDo sizeBanCo = new QuanLyCapDo();
        Bom bom = new Bom();
        public NutMinVaCo[,] MangNut;
        public int capDo;

        public GameLogic(int capDo)
        {

            this.capDo = capDo;

        }
        public void TaoBanCo()
        {

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
        //public void CreateButton(int i, int j)
        //{
        //    MangNut[i, j] = new NutMinVaCo(i, j, this)
        //    {
        //        trangThai = 0,
        //        Location = new System.Drawing.Point(i * 30, j * 30),
        //        Size = new System.Drawing.Size(30, 30)
        //    };
        //    this.Controls.Add(MangNut[i, j]);
        //}

        //public void VeOCo()
        //{
        //    MangNut = new NutMinVaCo[this.GetSizeBanCo(), this.GetSizeBanCo()];
        //    NutMinVaCo.mangNut = MangNut;
        //    for (int i = 0; i < this.GetSizeBanCo(); i++)
        //    {
        //        for (int j = 0; j < this.GetSizeBanCo(); j++)
        //        {
        //            CreateButton(i, j);
        //        }
        //    }
        //}
        public void DatMinNgauNhien()
        {
            int count = 0;
            while (count < this.GetSizeBomb())
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
                            if ((x < this.GetSizeBanCo() & y < this.GetSizeBanCo()) & (x >= 0 & y >= 0) & !(x == i & y == j))
                                if (MangNut[x, y].isMin)
                                    count++;
                    MangNut[i, j].countMinAround = count;
                }
            }
        }
        
    }
}
