namespace DA_TinHoc_Nhom6_Minesweeper
{
    partial class PlayGame
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
            this.lblSoCo = new System.Windows.Forms.Label();
            this.btnCo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoCo
            // 
            this.lblSoCo.AutoSize = true;
            this.lblSoCo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSoCo.Location = new System.Drawing.Point(666, 409);
            this.lblSoCo.Name = "lblSoCo";
            this.lblSoCo.Size = new System.Drawing.Size(19, 13);
            this.lblSoCo.TabIndex = 1;
            this.lblSoCo.Text = "co";
            // 
            // btnCo
            // 
            this.btnCo.BackgroundImage = global::DA_TinHoc_Nhom6_Minesweeper.Properties.Resources.flag;
            this.btnCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCo.Location = new System.Drawing.Point(596, 330);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(64, 92);
            this.btnCo.TabIndex = 2;
            this.btnCo.UseVisualStyleBackColor = true;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.lblSoCo);
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoCo;
        private System.Windows.Forms.Button btnCo;
    }
}