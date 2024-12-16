namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //#endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.lblTuaDe = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTuaDe
            // 
            this.lblTuaDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTuaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTuaDe.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuaDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTuaDe.Location = new System.Drawing.Point(177, 70);
            this.lblTuaDe.Name = "lblTuaDe";
            this.lblTuaDe.Size = new System.Drawing.Size(400, 93);
            this.lblTuaDe.TabIndex = 0;
            this.lblTuaDe.Text = "DÒ MÌN";
            this.lblTuaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBatDau.Location = new System.Drawing.Point(303, 203);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(144, 51);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuongDan.Location = new System.Drawing.Point(275, 292);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(202, 52);
            this.btnHuongDan.TabIndex = 2;
            this.btnHuongDan.Text = "HƯỚNG DẪN";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(723, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(38, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Khách";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::DA_TinHoc_Nhom6_Minesweeper.Properties.Resources.icons8_back_32;
            this.btnTroLai.Location = new System.Drawing.Point(12, 9);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(55, 33);
            this.btnTroLai.TabIndex = 5;
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblTuaDe);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuaDe;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnTroLai;
    }
}