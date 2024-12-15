using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.Http.Headers;
using DA_TinHoc_Nhom6_Minesweeper.PL;

namespace DA_TinHoc_Nhom6_Minesweeper.BLL
{
    //public class NutCo : Button
    //{
    //    public bool isFlagged = false;
    //    public int trangThai = -1;
    //    private PlayGame playGame;
    //    public NutMinVaCo[,] MangNut;
    //    private NutMinVaCo associatedNut;

    //    public NutCo(NutMinVaCo nut)
    //    {
    //        associatedNut = nut;
    //        this.MouseClick += new MouseEventHandler(NutCo_MouseRight);
    //    }

    //    private void NutCo_MouseRight(object sender, MouseEventArgs e)
    //    {
    //        if (e.Button == MouseButtons.Right)
    //        {
    //            // Toggle flag on the associated NutMinVaCo button
    //            if (!associatedNut.isFlagged)
    //            {
    //                // Flag the cell
    //                associatedNut.CamCo();
    //                associatedNut.isFlagged = true;
    //            }
    //            else
    //            {
    //                // Unflag the cell
    //                associatedNut.GoCo();
    //                associatedNut.isFlagged = false;
    //            }
    //        }
    //    }
    //    public void CamCo()
    //    {
    //        this.Text = "f";
    //        // Thêm hình ảnh cờ vào ô
    //        //this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\flag.png");
    //        //this.BackgroundImageLayout = ImageLayout.Zoom;
    //        //flagCount++;
    //        //// Cập nhật lại textbox txtFlagCount
    //        //txtFlagCount.Text = flagCount.ToString();
    //    }
    //    public void GoCo()
    //    {
    //        this.Text = "";
    //        //Xóa hình ảnh cờ
    //        //this.BackgroundImage = null;
    //        //if (flagCount > 0)
    //        //{
    //        //    flagCount--;
    //        //}
    //        //// Cập nhật lại textbox txtFlagCount
    //        //txtFlagCount.Text = flagCount.ToString();

    //    }
    //}
}
