namespace GameTA
{
    partial class Form1
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
            this.lblplay = new System.Windows.Forms.Label();
            this.lblhighscore = new System.Windows.Forms.Label();
            this.lbledit = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplay
            // 
            this.lblplay.AutoSize = true;
            this.lblplay.BackColor = System.Drawing.Color.Transparent;
            this.lblplay.Font = new System.Drawing.Font("000 Captain Comic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplay.Location = new System.Drawing.Point(623, 465);
            this.lblplay.Name = "lblplay";
            this.lblplay.Size = new System.Drawing.Size(117, 53);
            this.lblplay.TabIndex = 3;
            this.lblplay.Text = "Play";
            this.lblplay.Click += new System.EventHandler(this.lblplay_Click);
            this.lblplay.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblplay.MouseLeave += new System.EventHandler(this.lblplay_MouseLeave);
            // 
            // lblhighscore
            // 
            this.lblhighscore.AutoSize = true;
            this.lblhighscore.BackColor = System.Drawing.Color.Transparent;
            this.lblhighscore.Font = new System.Drawing.Font("000 Captain Comic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhighscore.Location = new System.Drawing.Point(554, 558);
            this.lblhighscore.Name = "lblhighscore";
            this.lblhighscore.Size = new System.Drawing.Size(255, 53);
            this.lblhighscore.TabIndex = 4;
            this.lblhighscore.Text = "high score";
            this.lblhighscore.Click += new System.EventHandler(this.lblhighscore_Click);
            this.lblhighscore.MouseEnter += new System.EventHandler(this.lblhighscore_MouseEnter);
            this.lblhighscore.MouseLeave += new System.EventHandler(this.lblhighscore_MouseLeave);
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.BackColor = System.Drawing.Color.Transparent;
            this.lbledit.Font = new System.Drawing.Font("000 Captain Comic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(631, 650);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(110, 53);
            this.lbledit.TabIndex = 5;
            this.lbledit.Text = "edit";
            this.lbledit.Click += new System.EventHandler(this.lbledit_Click);
            this.lbledit.MouseEnter += new System.EventHandler(this.lbledit_MouseEnter);
            this.lbledit.MouseLeave += new System.EventHandler(this.lbledit_MouseLeave);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GameTA.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.lbledit);
            this.Controls.Add(this.lblhighscore);
            this.Controls.Add(this.lblplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblplay;
        public System.Windows.Forms.Label lblhighscore;
        public System.Windows.Forms.Label lbledit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

