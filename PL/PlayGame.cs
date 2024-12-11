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

namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    public partial class PlayGame : Form
    {
        public User user = new User();
        QuanLyCapDo quanLyCapDo = new QuanLyCapDo();
        Bom bom = new Bom();
        public NutMinVaCo[,] MangNut;
        public int capDo;
        private readonly GameLogic gameLogic;

        public PlayGame(string taiKhoan,int capDo)
        {
            user.TaiKhoan = taiKhoan;
            InitializeComponent();

            DoubleBuffering();//giam hien tuong nhap nhay

            this.capDo = capDo;
            quanLyCapDo.sizeBanCo = this.GetSizeBanCo();
            bom.bomCount = this.GetSizeBomb();

            VeBanCo();

            gameLogic = new GameLogic(capDo)
            {
                MangNut = this.MangNut
            };

            txtPlayerName.Text = user.TaiKhoan;
            txtBombCount.Text = "Bomb: "+gameLogic.GetSizeBomb().ToString();

            gameLogic.TaoBanCo();
            HienThiMin();


        }
        public void DoubleBuffering()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
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
        public void CreateButton(int dong, int cot, Panel boardPanel)
        {

            MangNut[dong, cot] = new NutMinVaCo(dong, cot, this)
            {
                trangThai = 0,
                Location = new System.Drawing.Point(cot * quanLyCapDo.buttonSize, dong * quanLyCapDo.buttonSize),
                Size = new System.Drawing.Size(quanLyCapDo.buttonSize, quanLyCapDo.buttonSize)
            };
            //them vao panel thay vi form
            boardPanel.Controls.Add(MangNut[dong, cot]);
        }
        public void CreateBoardPanel()
        {
            Panel boardPanel = new DoubleBufferedPanel
            {
                Size = new Size(quanLyCapDo.sizeBanCo * quanLyCapDo.buttonSize, quanLyCapDo.sizeBanCo * quanLyCapDo.buttonSize),
                Location = new Point(0, 0),
                AutoScroll = true // Nếu bàn cờ lớn, cho phép cuộn
            };

            boardPanel.SuspendLayout();
            VeOCo(boardPanel);
            boardPanel.ResumeLayout();//để ngăn việc cập nhật giao diện trong quá trình thêm các control.

            //chi them vao 1 lan, giam thao tac tren form -> giup toi uu toc do
            this.Controls.Add(boardPanel);

        }

        public void VeOCo(Panel boardPanel)
        {
           
            MangNut = new NutMinVaCo[quanLyCapDo.sizeBanCo, quanLyCapDo.sizeBanCo];
            NutMinVaCo.mangNut = MangNut;
            // khoi tao san mang nut
            // tao san vi tri
            for (int dong = 0; dong < quanLyCapDo.sizeBanCo; dong++)
            {
                for (int cot = 0; cot < quanLyCapDo.sizeBanCo; cot++)
                {
                    CreateButton(dong, cot, boardPanel);
                }
            }
            
        }
        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
