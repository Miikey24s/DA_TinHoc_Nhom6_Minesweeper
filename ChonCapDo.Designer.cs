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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(622, 379);
            this.btnDe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(356, 144);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "Dễ";
            this.btnDe.UseVisualStyleBackColor = true;
            // 
            // btnVua
            // 
            this.btnVua.Location = new System.Drawing.Point(622, 535);
            this.btnVua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVua.Name = "btnVua";
            this.btnVua.Size = new System.Drawing.Size(356, 144);
            this.btnVua.TabIndex = 2;
            this.btnVua.Text = "Vừa";
            this.btnVua.UseVisualStyleBackColor = true;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Image = global::DA_TinHoc_Nhom6_Minesweeper.Properties.Resources.icons8_back_32;
            this.btnTroLai.Location = new System.Drawing.Point(24, 23);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(104, 54);
            this.btnTroLai.TabIndex = 4;
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // btnKho
            // 
            this.btnKho.AutoSize = true;
            this.btnKho.Location = new System.Drawing.Point(622, 690);
            this.btnKho.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(356, 144);
            this.btnKho.TabIndex = 5;
            this.btnKho.Text = "Khó";
            this.btnKho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn cấp độ";
            // 
            // ChonCapDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 887);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnVua);
            this.Controls.Add(this.btnDe);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChonCapDo";
            this.Text = "ten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Button btnVua;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Label label1;
    }
}