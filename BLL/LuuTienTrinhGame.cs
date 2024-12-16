using DA_TinHoc_Nhom6_Minesweeper.DAL;
using DA_TinHoc_Nhom6_Minesweeper.PL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{

    public static class LuuTienTrinhGamme
    {
        //public static User user = new User();


        public static void SaveTienTrinhGame(string username, NutMinVaCo[,] MangNut, int capDo)
        {
            using (StreamWriter writer = new StreamWriter($"{username}_Game_Save.txt"))
            {
                writer.WriteLine($"UserName: {username}");
                writer.WriteLine($"{capDo}");

                //int count = 0;
                for (int i = 0; i < MangNut.GetLength(0); i++)
                {
                    for (int j = 0; j < MangNut.GetLength(1); j++)
                    {
                        NutMinVaCo nut = MangNut[i, j];
                        writer.WriteLine($"{nut.d} {nut.c} {nut.isMin} {nut.isFlagged} {nut.clicked} {nut.countMinAround}");
                        //                 dòng / cột  /  có phải mìn kh / có cắm cờ kh / đã được Clicked chưa / số mìn xung quanh
                    }
                }
            }
        }

        public static (string, int) LoadTienTrinhGame(string username, User user)
        {
            if (!File.Exists($"{username}_game_Save.txt"))
            {
                return ("", -1);
            }

            string timePlayed = "";
            int capDo = -1;

            using (StreamReader reader = new StreamReader($"{username}_game_Save.txt"))
            {
                

                string userName = reader.ReadLine().Split(':')[1].Trim();
                capDo = int.Parse(reader.ReadLine().Split(' ')[0]);
                timePlayed = "";


                //string line;
                //while ((line = reader.ReadLine()) != null)
                //{
                //    string[] values = line.Split(' ');
                   
                    
                //    int d = int.Parse(values[0]);// Đang bị lỗi ở đây
                //    int c = int.Parse(values[1]);
                //    bool isMin = bool.Parse(values[2]);
                //    bool isFlagged = bool.Parse(values[3]);
                //    bool clicked = bool.Parse(values[4]);
                //    int countMinAround = int.Parse(values[5]);
                    

                //    NutMinVaCo nut = new NutMinVaCo(d, c, playGame, user)
                //    {
                //        isMin = isMin,
                //        isFlagged = isFlagged,
                //        clicked = clicked,
                //        countMinAround = countMinAround
                //    };
                //    playGame.MangNut[d, c] = nut;

                //}
                //MessageBox.Show(MangNut[0, 0].isFlagged.ToString());

            }
            
            return (timePlayed, capDo);
        }
        
        public static int LoadCapDo(string username)
        {
            if (!File.Exists($"{username}_game_Save.txt"))
            {
                return (-1);
            }

            int capDo = -1;
            using (StreamReader reader = new StreamReader($"{username}_game_Save.txt"))
            {


                string userName = reader.ReadLine().Split(':')[1].Trim();
                capDo = int.Parse(reader.ReadLine().Split(' ')[0]);
            }
            return (capDo);
        }
        public static PlayGame LoadMangNut(string username)
        {
            if (!File.Exists($"{username}_game_Save.txt"))
            {
                return (null);
            }
            //string timePlayed = "";
            
            int capDo = -1;
            PlayGame playGame;
            using (StreamReader reader = new StreamReader($"{username}_game_Save.txt"))
            {

                
                string userName = reader.ReadLine().Split(':')[1].Trim();
                capDo = int.Parse(reader.ReadLine().Split(' ')[0]);
                //timePlayed = "";
                playGame = new PlayGame(userName, capDo);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(' ');


                    int d = int.Parse(values[0]);// Đang bị lỗi ở đây
                    int c = int.Parse(values[1]);
                    bool isMin = bool.Parse(values[2]);
                    bool isFlagged = bool.Parse(values[3]);
                    bool clicked = bool.Parse(values[4]);
                    int countMinAround = int.Parse(values[5]);


                    playGame.MangNut[d, c].isMin = isMin;
                    playGame.MangNut[d, c].isFlagged = isFlagged;
                    playGame.MangNut[d, c].clicked = clicked;
                    playGame.MangNut[d, c].countMinAround = countMinAround;

                }

            }
            return (playGame);
        }
    }
}
    
    
    
