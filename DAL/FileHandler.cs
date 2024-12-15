using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper.DAL
{
    public class FileHandler
    {
        private static string dataTK = "DanhSachh.txt";
        private static string TGDangNhap = "ThoiGianChoi.txt";
        public static bool ghifile(User user)
        {
            try
            {
                FileStream fs = new FileStream(dataTK, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"{user.username},{user.password}");
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public static List<User> docFile()
        {
            {
                List<User> userList = new List<User>();
                FileStream fs = null;
                try
                {
                    fs = new FileStream(dataTK, FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(fs);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            User user = new User { username = parts[0], password = parts[1] };
                            userList.Add(user);
                        }
                    }
                    sr.Close();
                    fs.Close();
                    return userList;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public static void GhiThoiGianDangNhap(string taiKhoan)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(TGDangNhap, true))
                {
                    sw.WriteLine($"{taiKhoan},{DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi log thời gian chơi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
