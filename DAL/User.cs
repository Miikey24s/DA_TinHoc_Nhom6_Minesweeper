﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TinHoc_Nhom6_Minesweeper.DAL
{
    public class User
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        //private string filePath;
        //public User(string filePath)
        //{
        //    this.filePath = filePath;
        //}

        public bool AddUser(string username, string password)
        {
            //var users = GetAllUsers();
            //foreach (var user in users)
            //{
            //    if (user[0] == username) return false;
            //}

            //FileHandler.AppendToFile(filePath, $"{username},{password}");
            //return true;
            List<User> list = FileHandler.docFile();
            bool tonTai = false;
            if (!string.IsNullOrEmpty(username))
            {
                if (username != "")
                {
                    if (list != null)
                    {
                        foreach (User user in list)
                        {
                            if (user.TaiKhoan == username)
                            {
                                tonTai = true;
                                //flag = false;
                                break;
                            }
                        }
                    }
                    if (tonTai)
                    {
                        //MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        username = "";
                        password = "";
                    }
                    else
                    {
                        User user = new User
                        {
                            TaiKhoan = username,
                            MatKhau = password
                        };
                        //flag = true;
                        tonTai = false;
                        username = "";
                        password = "";


                        if (FileHandler.ghifile(user))
                            //MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        else
                            //MessageBox.Show("KHÔNG THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;

                    }
                }
            }
            return false;
        }

        //public List<string[]> GetAllUsers()
        //{
        //    //return FileHandler.ReadFile(filePath);
        //}

        public bool ValidateUser(string username, string password)
        {
            bool tontai = false;
            List<User> userList = FileHandler.docFile();
            if (username != "")
            {
                if (userList != null)
                {
                    foreach (User user in userList)
                    {
                        if (user.TaiKhoan == username && user.MatKhau != password)
                        {
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            password = "";
                            tontai = true;
                            break;

                        }

                    }
                }
            }
            if (userList != null)
            {
                bool flag = false;
                foreach (User user in userList)
                {
                    if (user.TaiKhoan == username && user.MatKhau == password)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Hide();
                    //TrangChu trangChu = new TrangChu(username);
                    //trangChu.ShowDialog();
                    //this.Close();
                    return true;
                }
                else if (tontai == false)
                {
                    MessageBox.Show("Tài khoản không tồn tại.\nSai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Không thể đọc danh sách tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
