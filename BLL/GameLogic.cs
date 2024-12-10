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

        public GameLogic(/*string taiKhoan,*/int capDo)
        {
            //this.TKDangChoi = taiKhoan;
            this.capDo = capDo;
            //this.chonCapDo = new ChonCapDo(taiKhoan);
            //TaoBanCo();
            //t.Interval = 1000;
            //t.Elapsed += CapNhatTG;
        }
        public void TaoBanCo()
        {
            //VeOCo();

            
            //txtPlayerName.Text = TKDangChoi;


            DatMinNgauNhien();
            DemMinXungQuanh();
            //HienThiMin();


        }
        //Cheat Hien Min
        //public void HienThiMin()
        //{
        //    for (int i = 0; i < GetSizeBanCo(); i++)
        //    {
        //        for (int j = 0; j < GetSizeBanCo(); j++)
        //        {
        //            if (MangNut[i, j].isMin)
        //            {
        //                MangNut[i, j].BackColor = Color.Red;
        //                MangNut[i, j].Open();
        //            }
        //        }
        //    }
        //}
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
        //public void StartTimer()
        //{
        //    if (!BatDau)
        //    {
        //        t.Start();
        //        BatDau = true;
        //    }
        //}
        //public void StopTimer()
        //{
        //    t.Stop();
        //    GhiThoiGianChoi(TKDangChoi, h, m, s);
        //}
        //public void CapNhatTG(object sender, ElapsedEventArgs e)
        //{
        //    Invoke(new Action(() =>
        //    {
        //        s += 1;
        //        if (s == 60)
        //        {
        //            s = 0;
        //            m += 1;
        //            if (m == 60)
        //            {
        //                m = 0;
        //                h += 1;
        //            }
        //        }
        //        txtTime.Text = $"{h:D2}:{m:D2}:{s:D2}";
        //    }));
        //}
        //private void GhiThoiGianChoi(string taiKhoan, int h, int m, int s)
        //{
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter("ThoiGianChoi.txt", true))
        //        {
        //            sw.WriteLine($"{taiKhoan},{h:D2}:{m:D2}:{s:D2}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi ghi log thời gian chơi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void txtPlayerName_TextChanged(object sender, EventArgs e)
        //{

        //}

        //public void KiemTraChienThang()
        //{
        //    foreach (NutMinVaCo nut in MangNut)
        //    {
        //        if (!nut.clicked) return;// Da click het cac nut
        //    }
        //    ThangTroChoi();
        //}

        //public void ThangTroChoi()
        //{
        //    DialogResult result;
        //    StopTimer();
        //    MessageBox.Show("Bạn đã thắng!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    result = MessageBox.Show("Bạn có muốn chơi lại không?", "Trò chơi đã thắng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        this.Hide();
        //        new ChonCapDo(TKDangChoi).ShowDialog();  //Chơi lại
        //        this.Close();
        //    }
        //    else
        //    {
        //        Application.Exit();  //Thoát
        //    }
        //} 

        //public void ThuaTroChoi()
        //{
        //    DialogResult result;
        //    t.Stop();

        //    MessageBox.Show("Bạn đã thua!", "Đáng tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    result = MessageBox.Show("Bạn có muốn chơi lại không?", "Chinh phục lại nào!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
        //    {
        //        this.Hide();
        //        new ChonCapDo(TKDangChoi).ShowDialog();  //Chơi lại
        //        this.Close();
        //    }
        //    else
        //    {
        //        Application.Exit();  //Thoát
        //    }
        //}
    }
}
