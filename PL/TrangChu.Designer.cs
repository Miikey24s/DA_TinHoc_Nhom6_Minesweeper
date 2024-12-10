namespace DA_TinHoc_Nhom6_Minesweeper
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
            this.SuspendLayout();
            // 
            // lblTuaDe
            // 
            this.lblTuaDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTuaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTuaDe.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuaDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTuaDe.Location = new System.Drawing.Point(236, 86);
            this.lblTuaDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuaDe.Name = "lblTuaDe";
            this.lblTuaDe.Size = new System.Drawing.Size(533, 115);
            this.lblTuaDe.TabIndex = 0;
            this.lblTuaDe.Text = "DÒ MÌN";
            this.lblTuaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBatDau.Location = new System.Drawing.Point(404, 250);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(192, 63);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuongDan.Location = new System.Drawing.Point(367, 359);
            this.btnHuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(270, 64);
            this.btnHuongDan.TabIndex = 2;
            this.btnHuongDan.Text = "HƯỚNG DẪN";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1031, 554);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblTuaDe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTuaDe;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnHuongDan;
    }
}