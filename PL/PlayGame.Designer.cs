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
            this.thongTinPanel = new DA_TinHoc_Nhom6_Minesweeper.BLL.DoubleBufferedPanel();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtFlagCount = new System.Windows.Forms.TextBox();
            this.txtBombCount = new System.Windows.Forms.TextBox();
            this.thongTinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // thongTinPanel
            // 
            this.thongTinPanel.Controls.Add(this.txtPlayerName);
            this.thongTinPanel.Controls.Add(this.txtTime);
            this.thongTinPanel.Controls.Add(this.txtFlagCount);
            this.thongTinPanel.Controls.Add(this.txtBombCount);
            this.thongTinPanel.Location = new System.Drawing.Point(445, 10);
            this.thongTinPanel.Margin = new System.Windows.Forms.Padding(2);
            this.thongTinPanel.Name = "thongTinPanel";
            this.thongTinPanel.Size = new System.Drawing.Size(211, 96);
            this.thongTinPanel.TabIndex = 3;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtPlayerName.Location = new System.Drawing.Point(2, 5);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(100, 40);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTime.Location = new System.Drawing.Point(100, 5);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 40);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "00:00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlagCount
            // 
            this.txtFlagCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFlagCount.Location = new System.Drawing.Point(2, 47);
            this.txtFlagCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtFlagCount.Multiline = true;
            this.txtFlagCount.Name = "txtFlagCount";
            this.txtFlagCount.ReadOnly = true;
            this.txtFlagCount.Size = new System.Drawing.Size(100, 40);
            this.txtFlagCount.TabIndex = 3;
            // 
            // txtBombCount
            // 
            this.txtBombCount.Enabled = false;
            this.txtBombCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtBombCount.Location = new System.Drawing.Point(100, 47);
            this.txtBombCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBombCount.Multiline = true;
            this.txtBombCount.Name = "txtBombCount";
            this.txtBombCount.ReadOnly = true;
            this.txtBombCount.Size = new System.Drawing.Size(100, 40);
            this.txtBombCount.TabIndex = 2;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 413);
            this.Controls.Add(this.thongTinPanel);
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayGame";
            this.thongTinPanel.ResumeLayout(false);
            this.thongTinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtBombCount;
        private BLL.DoubleBufferedPanel thongTinPanel;
        private System.Windows.Forms.TextBox txtFlagCount;
    }
}