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

        string username;
        private System.Windows.Forms.TextBox txtTime;
        public int h, m, s;
        public bool BatDau = false;
        public static bool isResume = false;
        public DemThoiGianChoi(System.Windows.Forms.TextBox txtTime,string TKDangChoi)
        {
            this.txtTime = txtTime;
            this.username = TKDangChoi;
            
            h = m = s = 0;
            t.Interval = 1000;
            t.Elapsed += CapNhatTG;
        }
        public void CountineTimer()
        {
            t.Start();
        }
        public void StartTimer()
        {
            if (!BatDau)
            {
                // Lấy thời gian cuối cùng của người dùng hiện tại
                if (isResume) (h, m, s) = LayThoiGianCuoiCung(username);

                // Cập nhật hiển thị thời gian
                txtTime.Text = $"{h:D2}:{m:D2}:{s:D2}";

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
            GhiThoiGianChoi(username, h, m, s);
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
        private (int h, int m, int s) LayThoiGianCuoiCung(string username)
        {
            try
            {
                // Đọc toàn bộ các dòng trong file
                var lines = File.ReadAllLines("ThoiGianChoi.txt").Reverse();
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2 && parts[0].Trim() == username) // Kiểm tra tên người dùng
                    {
                        string[] timeParts = parts[1].Split(':');
                        if (timeParts.Length == 3 &&
                            int.TryParse(timeParts[0], out int h) &&
                            int.TryParse(timeParts[1], out int m) &&
                            int.TryParse(timeParts[2], out int s))
                        {
                            return (h, m, s); // Trả về giờ, phút, giây
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file thời gian chơi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (0, 0, 0); // Trả về thời gian mặc định nếu không tìm thấy
        }



        public static void  GhiThoiGianChoi(string username, int h, int m, int s)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("ThoiGianChoi.txt", true))
                {
                    sw.WriteLine($"{username},{h:D2}:{m:D2}:{s:D2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi log thời gian chơi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
