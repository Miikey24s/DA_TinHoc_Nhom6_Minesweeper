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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;
using DA_TinHoc_Nhom6_Minesweeper.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection.Emit;

namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    public partial class PlayGame : Form
    {
        //System.Timers.Timer t = new System.Timers.Timer();
        public string TKDangChoi { get; }
        //public int h, m, s;
        //public bool BatDau = false;
        ChonCapDo chonCapDo;
        QuanLyCapDo sizeBanCo = new QuanLyCapDo();
        Bom bom = new Bom();
        public NutMinVaCo[,] MangNut;
        
        public int capDo;

        private readonly GameLogic gameLogic;

        public PlayGame(string taiKhoan,int capDo)
        {
            this.TKDangChoi = taiKhoan;
            InitializeComponent();
            this.capDo = capDo;
            this.chonCapDo = new ChonCapDo();
            VeBanCo();


            gameLogic = new GameLogic(capDo);
            gameLogic.MangNut = this.MangNut;
            //VeBanCo();
            gameLogic.TaoBanCo();
            HienThiMin();
        }
        
        public void VeBanCo()
        {
            VeOCo();
            //DatMinNgauNhien();
            //DemMinXungQuanh();
            //HienThiMin();
            txtPlayerName.Text = TKDangChoi;

        }
        public void HienThiMin()
        {
            for (int i = 0; i < GetSizeBanCo(); i++)
            {
                for (int j = 0; j < GetSizeBanCo(); j++)
                {
                    if (MangNut[i, j].isMin)
                    {
                        MangNut[i, j].BackColor = Color.Red;
                        MangNut[i, j].Open();
                    }
                }
            }
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
            MangNut[i, j] = new NutMinVaCo(i, j, this)
            {
                trangThai = 0,
                Location = new System.Drawing.Point(i * 30, j * 30),
                Size = new System.Drawing.Size(30, 30)
            };
            this.Controls.Add(MangNut[i, j]);
        }

        public void VeOCo()
        {
            MangNut = new NutMinVaCo[this.GetSizeBanCo(), this.GetSizeBanCo()];
            NutMinVaCo.mangNut = MangNut;
            for (int i = 0; i < this.GetSizeBanCo(); i++)
            {
                for (int j = 0; j < this.GetSizeBanCo(); j++)
                {
                    CreateButton(i, j);
                }
            }
        }
        //public void DatMinNgauNhien()
        //{
        //    int count = 0;
        //    while (count < GetSizeBomb())
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
        //public void DemMinXungQuanh()
        //{
        //    for (int i = 0; i < this.GetSizeBanCo(); i++)
        //    {
        //        for (int j = 0; j < this.GetSizeBanCo(); j++)
        //        {
        //            int count = 0;
        //            for (int x = i - 1; x <= i + 1; x++)
        //                for (int y = j - 1; y <= j + 1; y++)
        //                    if ((x < GetSizeBanCo() & y < GetSizeBanCo()) & (x >= 0 & y >= 0) & !(x == i & y == j))
        //                        if (MangNut[x, y].isMin)
        //                            count++;
        //            MangNut[i, j].countMinAround = count;
        //        }
        //    }
        //}
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

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

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
