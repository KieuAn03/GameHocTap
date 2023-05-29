using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace GameTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileSystemWatcher1 = new FileSystemWatcher(@"play/");
            fileSystemWatcher1.NotifyFilter = NotifyFilters.Attributes;
            fileSystemWatcher1.Changed += OnChanged;
            fileSystemWatcher1.EnableRaisingEvents = true;

        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Changed:  {e.FullPath}");
            Thread ig = new Thread(Rungame);
            ig.Start();
            

        }
        
        private void Rungame()
        {
            
                try
                {
                    if (this.InvokeRequired)
                    {
                      this.Invoke(new Action(Rungame));
                        return;
                    }
                foreach (Control c in this.Controls)
                {
                    if (c.Name == "lblplay" || c.Name == "lblhighscore" || c.Name == "lbledit")
                    {
                        continue;
                    }
                    c.Dispose();
                }
                        InGame ig = new InGame();
                        ig.Dock = DockStyle.Fill;
                        this.Controls.Add(ig);
                        ig.BringToFront();
                    

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            

        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected virtual bool DoubleBuffered { get; set; }

        private void inGame1_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblplay.ForeColor = Color.AliceBlue;
            this.Cursor = Cursors.Hand;
        }

        private void lblplay_Click(object sender, EventArgs e)
        {
            select_topic select = new select_topic();
            
            select.Dock = DockStyle.Fill;
            this.Controls.Add(select);
            select.BringToFront();
        }

        private void lblhighscore_MouseEnter(object sender, EventArgs e)
        {
            lblhighscore.ForeColor = Color.AliceBlue;
            this.Cursor = Cursors.Hand;
        }

        private void lbledit_MouseEnter(object sender, EventArgs e)
        {
            lbledit.ForeColor = Color.AliceBlue;
            this.Cursor = Cursors.Hand;
        }

        private void lblplay_MouseLeave(object sender, EventArgs e)
        {
            lblplay.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void lblhighscore_MouseLeave(object sender, EventArgs e)
        {
            lblhighscore.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void lbledit_MouseLeave(object sender, EventArgs e)
        {
            lbledit.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void select_topic1_Load(object sender, EventArgs e)
        {

        }

        private void lblhighscore_Click(object sender, EventArgs e)
        {
            highscore hi = new highscore();
            this.Controls.Add(hi);
            hi.Dock = DockStyle.Fill;
            hi.BringToFront();
        }

        private void lbledit_Click(object sender, EventArgs e)
        {
            settings settg = new settings();
            this.Controls.Add(settg);
            settg.Dock = DockStyle.Fill;
            settg.BringToFront();
        }
    }
}
