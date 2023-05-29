namespace GameTA
{
    partial class InGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.btnendgame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.result1 = new GameTA.result();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameTA.Properties.Resources.camel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(618, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(418, 544);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GameTA.Properties.Resources.question;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-48, 463);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 305);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.label1.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.label2.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "/5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.label3.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Score:";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.lblscore.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(217, 693);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(38, 41);
            this.lblscore.TabIndex = 6;
            this.lblscore.Text = "0";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(223)))));
            this.lblnum.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(219, 642);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(38, 41);
            this.lblnum.TabIndex = 7;
            this.lblnum.Text = "0";
            // 
            // btnendgame
            // 
            this.btnendgame.BackColor = System.Drawing.Color.PaleGreen;
            this.btnendgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnendgame.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnendgame.Location = new System.Drawing.Point(966, 661);
            this.btnendgame.Name = "btnendgame";
            this.btnendgame.Size = new System.Drawing.Size(326, 73);
            this.btnendgame.TabIndex = 11;
            this.btnendgame.Text = "or press here";
            this.btnendgame.UseVisualStyleBackColor = false;
            this.btnendgame.Click += new System.EventHandler(this.btnendgame_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.White;
            this.lbltime.Font = new System.Drawing.Font("000 Captain Comic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(354, 267);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(70, 41);
            this.lbltime.TabIndex = 15;
            this.lbltime.Text = "0 s";
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(-48, -60);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(1443, 959);
            this.axWindowsMediaPlayer2.TabIndex = 9;
            this.axWindowsMediaPlayer2.Enter += new System.EventHandler(this.axWindowsMediaPlayer2_Enter);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // result1
            // 
            this.result1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("result1.BackgroundImage")));
            this.result1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.result1.Location = new System.Drawing.Point(0, 0);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(1360, 768);
            this.result1.TabIndex = 12;
            this.result1.Visible = false;
            this.result1.Load += new System.EventHandler(this.result1_Load);
            this.result1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.result1_ControlRemoved);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTA.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.result1);
            this.Controls.Add(this.btnendgame);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltime);
            this.DoubleBuffered = true;
            this.Name = "InGame";
            this.Size = new System.Drawing.Size(1360, 768);
            this.Load += new System.EventHandler(this.InGame_Load);
            this.VisibleChanged += new System.EventHandler(this.InGame_VisibleChanged);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.InGame_ControlRemoved);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnendgame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private result result1;
    }
}
