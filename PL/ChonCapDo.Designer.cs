namespace DA_TinHoc_Nhom6_Minesweeper.PL
{
    partial class ChonCapDo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonCapDo));
            this.btnDe = new System.Windows.Forms.Button();
            this.btnVua = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDe
            // 
            this.btnDe.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDe.Location = new System.Drawing.Point(317, 221);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(140, 60);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "Dễ";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // btnVua
            // 
            this.btnVua.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVua.Location = new System.Drawing.Point(317, 287);
            this.btnVua.Name = "btnVua";
            this.btnVua.Size = new System.Drawing.Size(140, 60);
            this.btnVua.TabIndex = 2;
            this.btnVua.Text = "Vừa";
            this.btnVua.UseVisualStyleBackColor = true;
            this.btnVua.Click += new System.EventHandler(this.btnVua_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::DA_TinHoc_Nhom6_Minesweeper.Properties.Resources.icons8_back_32;
            this.btnTroLai.Location = new System.Drawing.Point(10, 11);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(55, 33);
            this.btnTroLai.TabIndex = 4;
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnKho
            // 
            this.btnKho.AutoSize = true;
            this.btnKho.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKho.Location = new System.Drawing.Point(317, 353);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(140, 60);
            this.btnKho.TabIndex = 5;
            this.btnKho.Text = "Khó";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHỌN CẤP ĐỘ";
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnResume.Location = new System.Drawing.Point(317, 155);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(140, 60);
            this.btnResume.TabIndex = 7;
            this.btnResume.Text = "Tiếp tục";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // ChonCapDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnVua);
            this.Controls.Add(this.btnDe);
            this.Name = "ChonCapDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn cấp độ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Button btnVua;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResume;
    }
}