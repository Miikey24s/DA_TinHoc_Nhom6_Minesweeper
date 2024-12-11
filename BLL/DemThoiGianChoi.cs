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

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    public class DemThoiGianChoi
    {
        System.Timers.Timer t = new System.Timers.Timer();

        string TKDangChoi = "*";
        private System.Windows.Forms.TextBox txtTime;
        public int h, m, s;
        public bool BatDau = false;
        public DemThoiGianChoi(System.Windows.Forms.TextBox txtTime,string TKDangChoi)
        {
            this.txtTime = txtTime;
            this.TKDangChoi = User.GetTKDangChoi();
            h = m = s = 0;
            t.Interval = 1000;
            t.Elapsed += CapNhatTG;
        }
        public void StartTimer()
        {
            if (!BatDau)
            {
                t.Start();
                BatDau = true;
            }
        }
        public void StopTimerNoSave()
        {
            t.Stop();
            BatDau = false;
        }
        public void StopTimerAndSave()
        {
            t.Stop();
            GhiThoiGianChoi(TKDangChoi, h, m, s);
            BatDau = false;
        }

        public void CapNhatTG(object sender, ElapsedEventArgs e) {

            txtTime.Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                    if (m == 60)
                    {
                        m = 0;
                        h += 1;
                    }
                }
                txtTime.Text = $"{h:D2}:{m:D2}:{s:D2}";
            }));
        }

        private void GhiThoiGianChoi(string TKDangChoi, int h, int m, int s)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("ThoiGianChoi.txt", true))
                {
                    sw.WriteLine($"{TKDangChoi},{h:D2}:{m:D2}:{s:D2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi log thời gian chơi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
