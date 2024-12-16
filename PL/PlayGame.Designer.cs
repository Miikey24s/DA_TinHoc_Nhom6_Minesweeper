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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtFlagCount = new System.Windows.Forms.TextBox();
            this.txtBombCount = new System.Windows.Forms.TextBox();
            this.thongTinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // thongTinPanel
            // 
            this.thongTinPanel.Controls.Add(this.txtScore);
            this.thongTinPanel.Controls.Add(this.btnResume);
            this.thongTinPanel.Controls.Add(this.btnPause);
            this.thongTinPanel.Controls.Add(this.txtPlayerName);
            this.thongTinPanel.Controls.Add(this.txtTime);
            this.thongTinPanel.Controls.Add(this.txtFlagCount);
            this.thongTinPanel.Controls.Add(this.txtBombCount);
            this.thongTinPanel.Location = new System.Drawing.Point(445, 10);
            this.thongTinPanel.Margin = new System.Windows.Forms.Padding(2);
            this.thongTinPanel.Name = "thongTinPanel";
            this.thongTinPanel.Size = new System.Drawing.Size(244, 157);
            this.thongTinPanel.TabIndex = 3;
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtScore.Location = new System.Drawing.Point(2, 47);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(117, 40);
            this.txtScore.TabIndex = 6;
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(123, 130);
            this.btnResume.Margin = new System.Windows.Forms.Padding(2);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(119, 27);
            this.btnResume.TabIndex = 5;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(-9, 130);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(128, 27);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPlayerName.Location = new System.Drawing.Point(2, 1);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.ReadOnly = true;
            this.txtPlayerName.Size = new System.Drawing.Size(240, 44);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTime.Location = new System.Drawing.Point(123, 47);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(119, 40);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "00:00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlagCount
            // 
            this.txtFlagCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFlagCount.Location = new System.Drawing.Point(2, 91);
            this.txtFlagCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtFlagCount.Multiline = true;
            this.txtFlagCount.Name = "txtFlagCount";
            this.txtFlagCount.ReadOnly = true;
            this.txtFlagCount.Size = new System.Drawing.Size(117, 40);
            this.txtFlagCount.TabIndex = 3;
            // 
            // txtBombCount
            // 
            this.txtBombCount.Enabled = false;
            this.txtBombCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtBombCount.Location = new System.Drawing.Point(123, 91);
            this.txtBombCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBombCount.Multiline = true;
            this.txtBombCount.Name = "txtBombCount";
            this.txtBombCount.ReadOnly = true;
            this.txtBombCount.Size = new System.Drawing.Size(119, 40);
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
            this.Text = "6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayGame_FormClosing);
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
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TextBox txtScore;
    }
}