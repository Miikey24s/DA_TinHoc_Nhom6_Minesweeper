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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(934, 12);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(121, 29);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "00:00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(829, 16);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(95, 22);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.txtTime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPlayerName;
    }
}