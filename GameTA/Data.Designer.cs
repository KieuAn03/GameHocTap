namespace GameTA
{
    partial class Data
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
            this.lblback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.BackColor = System.Drawing.Color.Transparent;
            this.lblback.Font = new System.Drawing.Font("000 Captain Comic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblback.Location = new System.Drawing.Point(15, 0);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(123, 53);
            this.lblback.TabIndex = 4;
            this.lblback.Text = "back";
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTA.Properties.Resources.data;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblback);
            this.Name = "Data";
            this.Size = new System.Drawing.Size(1360, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblback;
    }
}
