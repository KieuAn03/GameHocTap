namespace GameTA
{
    partial class settings
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
            this.lbldata = new System.Windows.Forms.Label();
            this.lblback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("000 Captain Comic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(1080, 653);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(117, 53);
            this.lbldata.TabIndex = 4;
            this.lbldata.Text = "Play";
            this.lbldata.Click += new System.EventHandler(this.lbldata_Click);
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.BackColor = System.Drawing.Color.Transparent;
            this.lblback.Font = new System.Drawing.Font("000 Captain Comic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblback.Location = new System.Drawing.Point(23, 14);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(117, 53);
            this.lblback.TabIndex = 5;
            this.lblback.Text = "Play";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTA.Properties.Resources.setting__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.lbldata);
            this.DoubleBuffered = true;
            this.Name = "settings";
            this.Size = new System.Drawing.Size(1360, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbldata;
        public System.Windows.Forms.Label lblback;
    }
}
