namespace DA_TinHoc_Nhom6_Minesweeper.PL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtBombCount = new System.Windows.Forms.TextBox();
            this.txtFlagCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTime.Location = new System.Drawing.Point(950, 42);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(107, 38);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "00:00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(950, 11);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(107, 22);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtBombCount
            // 
            this.txtBombCount.Location = new System.Drawing.Point(950, 88);
            this.txtBombCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBombCount.Name = "txtBombCount";
            this.txtBombCount.ReadOnly = true;
            this.txtBombCount.Size = new System.Drawing.Size(107, 22);
            this.txtBombCount.TabIndex = 2;
            // 
            // txtFlagCount
            // 
            this.txtFlagCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFlagCount.Location = new System.Drawing.Point(950, 118);
            this.txtFlagCount.Name = "txtFlagCount";
            this.txtFlagCount.Size = new System.Drawing.Size(107, 34);
            this.txtFlagCount.TabIndex = 3;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1069, 508);
            this.Controls.Add(this.txtFlagCount);
            this.Controls.Add(this.txtBombCount);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.txtTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtBombCount;
        private System.Windows.Forms.TextBox txtFlagCount;
    }
}