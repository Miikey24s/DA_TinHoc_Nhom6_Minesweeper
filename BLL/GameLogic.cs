using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        //public void DatMinNgauNhien()
        //{
        //    int count = 0;
        //    while (count < this.GetSizeBomb())
        //    {
        //        int index = new Random().Next(GetSizeBanCo() * GetSizeBanCo());
        //        int r = index / GetSizeBanCo();
        //        int c = index % GetSizeBanCo();

        //        if (!MangNut[r, c].isMin)
        //        {
        //            MangNut[r, c].isMin = true;
        //            count++;
        //        }
        //    }
        //}
        public void DatMinNgauNhien()
        {
            int count = 0;
            Random rand = new Random(DateTime.Now.Millisecond); // Dùng thời gian hiện tại làm hạt giống

            while (count < this.GetSizeBomb())
            {
                // Tạo chỉ số ngẫu nhiên cho dòng và cột
                int r = rand.Next(GetSizeBanCo());
                int c = rand.Next(GetSizeBanCo());

                // Kiểm tra nếu ô đó chưa có mìn, thì đặt mìn vào
                if (!MangNut[r, c].isMin)
                {
                    MangNut[r, c].isMin = true;
                    count++; // Tăng số lượng mìn đã đặt
                }
            }
        }
        public void DemMinXungQuanh()
        {
            int size = this.GetSizeBanCo();
            // Duyệt qua tất cả các ô để tính số mìn xung quanh
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // Nếu ô hiện tại chứa mìn, ta sẽ cộng số mìn cho các ô xung quanh
                    if (MangNut[i, j].isMin)
                    {
                        // Duyệt qua các ô xung quanh (bao gồm các ô trên, dưới, trái, phải, và chéo)
                        for (int x = Math.Max(0, i - 1); x <= Math.Min(size - 1, i + 1); x++)
                        {
                            for (int y = Math.Max(0, j - 1); y <= Math.Min(size - 1, j + 1); y++)
                            {
                                // Nếu ô (x, y) không phải là ô (i, j) và không phải là mìn
                                if (x != i || y != j)
                                {
                                    MangNut[x, y].countMinAround++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
