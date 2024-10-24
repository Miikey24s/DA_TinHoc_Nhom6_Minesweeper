namespace DA_TinHoc_Nhom6_Minesweeper
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
            this.btnDe = new System.Windows.Forms.Button();
            this.btnVua = new System.Windows.Forms.Button();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(311, 197);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(178, 75);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "Dễ";
            this.btnDe.UseVisualStyleBackColor = true;
            // 
            // btnVua
            // 
            this.btnVua.Location = new System.Drawing.Point(311, 278);
            this.btnVua.Name = "btnVua";
            this.btnVua.Size = new System.Drawing.Size(178, 75);
            this.btnVua.TabIndex = 2;
            this.btnVua.Text = "Vừa";
            this.btnVua.UseVisualStyleBackColor = true;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::DA_TinHoc_Nhom6_Minesweeper.Properties.Resources.icons8_back_32;
            this.btnTroLai.Location = new System.Drawing.Point(12, 12);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(52, 28);
            this.btnTroLai.TabIndex = 4;
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // btnKho
            // 
            this.btnKho.AutoSize = true;
            this.btnKho.Location = new System.Drawing.Point(311, 359);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(178, 75);
            this.btnKho.TabIndex = 5;
            this.btnKho.Text = "Khó";
            this.btnKho.UseVisualStyleBackColor = true;
            // 
            // ChonCapDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnVua);
            this.Controls.Add(this.btnDe);
            this.Name = "ChonCapDo";
            this.Text = "ChonCapDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Button btnVua;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnKho;
    }
}