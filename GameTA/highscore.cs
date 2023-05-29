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

namespace GameTA
{
    public partial class highscore : UserControl
    {
        public highscore()
        {
            InitializeComponent();
            if (File.Exists(@"highscore.txt")){
                string[] line = File.ReadAllLines(@"highscore.txt");
                string b = "";
                foreach (string ln in line)
                {
                    if (ln == line[line.Length - 1])
                    {
                        b += ln;
                        break;
                    }
                    b += ln + ";";
                }
                var a = b.Split(';').Select(x => x.Split('\t')).ToArray();
                try
                {
                    lblname1.Text = a[0][0];
                    lbltopic1.Text = a[0][1];
                    lblscore1.Text = a[0][2];
                    lbltime1.Text = a[0][3];
                }
                catch
                {
                    lblname1.Text = "";
                    lbltopic1.Text = "";
                    lblscore1.Text = "";
                    lbltime1.Text = "";
                }




                try
                {
                    lblname2.Text = a[1][0];
                    lbltopic2.Text = a[1][1];
                    lblscore2.Text = a[1][2];
                    lbltime2.Text = a[1][3];
                }
                catch
                {
                    lblname2.Text = "";
                    lbltopic2.Text = "";
                    lblscore2.Text = "";
                    lbltime2.Text = "";
                }
                try
                {
                    lblname3.Text = a[2][0];
                    lbltopic3.Text = a[2][1];
                    lblscore3.Text = a[2][2];
                    lbltime3.Text = a[2][3];
                }
                catch
                {
                    lblname3.Text = "";
                    lbltopic3.Text = "";
                    lblscore3.Text = "";
                    lbltime3.Text = "";
                }
                try
                {
                    lblname4.Text = a[3][0];
                    lbltopic4.Text = a[3][1];
                    lblscore4.Text = a[3][2];
                    lbltime4.Text = a[3][3];
                }
                catch
                {
                    lblname4.Text = "";
                    lbltopic4.Text = "";
                    lblscore4.Text = "";
                    lbltime4.Text = "";
                }
                try
                {
                    lblname5.Text = a[4][0];
                    lbltopic5.Text = a[4][1];
                    lblscore5.Text = a[4][2];
                    lbltime5.Text = a[4][3];
                }
                catch
                {
                    lblname5.Text = "";
                    lbltopic5.Text = "";
                    lblscore5.Text = "";
                    lbltime5.Text = "";
                }





            }
        }

        private void lblplay_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void highscore_Load(object sender, EventArgs e)
        {

        }
    }
}
