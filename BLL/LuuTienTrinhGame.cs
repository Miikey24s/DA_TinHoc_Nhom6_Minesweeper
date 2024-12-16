using DA_TinHoc_Nhom6_Minesweeper.DAL;
using DA_TinHoc_Nhom6_Minesweeper.PL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{

    public static class LuuTienTrinhGamme
    {
        public static User user = new User();


        public static void SaveTienTrinhGame(string username, NutMinVaCo[,] MangNut)
        {
            using (StreamWriter writer = new StreamWriter($"{username}_Game_Save.txt"))
            {
                writer.WriteLine($"UserName: {username}");


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

        public static (NutMinVaCo[,], string) LoadTienTrinhGame(string username, int rows, int columns, PlayGame playGame)
        {
            if (!File.Exists($"{username}_game_Save.txt"))
            {
                return (null, "");
            }

            NutMinVaCo[,] MangNut = new NutMinVaCo[rows, columns];
            string timePlayed = "";

            using (StreamReader reader = new StreamReader($"{username}_game_Save.txt"))
            {
                string userName = reader.ReadLine().Split(':')[1].Trim();
                timePlayed = "";

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

                    NutMinVaCo nut = new NutMinVaCo(d, c, playGame, user)
                    {
                        isMin = isMin,
                        isFlagged = isFlagged,
                        clicked = clicked,
                        countMinAround = countMinAround
                    };
                    MangNut[d, c] = nut;
                }
            }

            return (MangNut, timePlayed);
        }
    }
}
    
    
    
