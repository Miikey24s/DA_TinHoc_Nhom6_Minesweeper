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
            this.lblTuaDe = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTuaDe
            // 
            this.lblTuaDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTuaDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTuaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTuaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTuaDe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTuaDe.Location = new System.Drawing.Point(186, 66);
            this.lblTuaDe.Name = "lblTuaDe";
            this.lblTuaDe.Size = new System.Drawing.Size(400, 50);
            this.lblTuaDe.TabIndex = 0;
            this.lblTuaDe.Text = "DÒ MINE ĐÊ!!!";
            this.lblTuaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBatDau.Location = new System.Drawing.Point(301, 203);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(144, 51);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuongDan.Location = new System.Drawing.Point(269, 294);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(208, 52);
            this.btnHuongDan.TabIndex = 2;
            this.btnHuongDan.Text = "HƯỚNG DẪN";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblTuaDe);
            this.Name = "TrangChu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTuaDe;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnHuongDan;
    }
}