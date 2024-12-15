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
using DA_TinHoc_Nhom6_Minesweeper.DAL;
using Label = System.Windows.Forms.Label;

namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    public partial class PlayGame : Form
    {
        public User user = new User();
        public QuanLyCapDo quanLyCapDo = new QuanLyCapDo();
        public Bom bom = new Bom();
        public NutMinVaCo[,] MangNut;
        public DemThoiGianChoi demtg;
        public int capDo;
        private readonly GameLogic gameLogic;
        public int flagCount = 0;
        
        Panel boardPanel;
        public PlayGame(string taiKhoan,int capDo)
        {
            user.username = taiKhoan;
            InitializeComponent();
            //txtPlayerName.Text = TKDangChoi;
            this.capDo = capDo;
            //VeBanCo();
            demtg = new DemThoiGianChoi(txtTime, user.username);
            this.capDo = capDo;
            quanLyCapDo.sizeBanCo = this.GetSizeBanCo();
            bom.bomCount = this.GetSizeBomb();

            VeGiaoDien();

            gameLogic = new GameLogic(capDo)
            {
                MangNut = this.MangNut
            };

            

            gameLogic.TaoBanCo();
            //HienThiMin();
            CapNhapSoCo();
        }
        private void CapNhapSoCo()
        {
            txtFlagCount.Text = "Số cờ: " + flagCount.ToString();
        }

        // Method to increase flag count
        public void IncreaseFlagCount()
        {
            flagCount++;
            CapNhapSoCo();
            
        }

        // Method to decrease flag count
        public void DecreaseFlagCount()
        {
            flagCount--;
            CapNhapSoCo();
            
        }
        public void DoubleBuffering()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        public void VeGiaoDien()
        {
            VeBanCo();
            VeThongTin();
        }
        public void VeThongTin()
        {
            txtPlayerName.Text = this.user.username;
            txtBombCount.Text = "Bomb: " + bom.bomCount.ToString();
            thongTinPanel.Location = new Point(quanLyCapDo.sizeBanCo * quanLyCapDo.buttonSize + 10, 0);

            
            int width = this.boardPanel.Width + this.thongTinPanel.Width + 50;//chieu ngang
            int height = this.boardPanel.Height + 50;//chieu doc
            this.Size = new Size(width, height);

        }
        public void VeBanCo()
        {
            CreateBoardPanel();
            
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
            quanLyCapDo.ChonSizeBanCo(this.capDo);
            return quanLyCapDo.GetSizeBanCo();
        }

        public int GetSizeBomb()
        {
            // lay so bom theo cap do
            bom.ChonSoBombs(this.capDo);
            return bom.GetBombs();
        }
        // i, j ten bien
        public void CreateButton(int dong, int cot)
        {

            MangNut[dong, cot] = new NutMinVaCo(dong, cot, this, user)
            {
                trangThai = 0,
                Location = new System.Drawing.Point(cot * quanLyCapDo.buttonSize, dong * quanLyCapDo.buttonSize),
                Size = new System.Drawing.Size(quanLyCapDo.buttonSize, quanLyCapDo.buttonSize)
            };
            //them vao panel thay vi form
            this.boardPanel.Controls.Add(MangNut[dong, cot]);
        }
        public void CreateBoardPanel()
        {
            this.boardPanel = new DoubleBufferedPanel
            {
                Size = new Size(quanLyCapDo.sizeBanCo * quanLyCapDo.buttonSize, quanLyCapDo.sizeBanCo * quanLyCapDo.buttonSize),
                Location = new Point(0, 0),
                AutoScroll = true // Nếu bàn cờ lớn, cho phép cuộn
            };

            this.boardPanel.SuspendLayout();
            VeOCo();
            this.boardPanel.ResumeLayout();//để ngăn việc cập nhật giao diện trong quá trình thêm các control.
            this.Controls.Add(this.boardPanel);

        }

        public void VeOCo()
        {
           
            MangNut = new NutMinVaCo[quanLyCapDo.sizeBanCo, quanLyCapDo.sizeBanCo];
            NutMinVaCo.mangNut = MangNut;
            // khoi tao san mang nut
            // tao san vi tri
            for (int dong = 0; dong < quanLyCapDo.sizeBanCo; dong++)
            {
                for (int cot = 0; cot < quanLyCapDo.sizeBanCo; cot++)
                {
                    CreateButton(dong, cot);
                }
            }
            
        }
        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
