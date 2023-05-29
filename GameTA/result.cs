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
using System.Linq;
namespace GameTA
{
    public partial class result : UserControl
    {
        public result()
        {
            InitializeComponent();
        }

        private void btnendgame_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor= Color.Black;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void lcor1_Click(object sender, EventArgs e)
        {

        }

        private void lcor5_Click(object sender, EventArgs e)
        {

        }

        private void result_Load(object sender, EventArgs e)
        {

        }
        private void check_TOP()
        {
            
            if (File.Exists(@"highscore.txt"))
            {
                //checktop:
                
                string[] line = File.ReadAllLines(@"highscore.txt");
                if(line.Length <5)
                {
                    File.AppendAllText(@"highscore.txt", txtname.Text + "\t" + lbltopic.Text + "\t" + lblscore.Text + "\t" + lbltime.Text + Environment.NewLine);
                    string[] line2 = File.ReadAllLines(@"highscore.txt");
                    sorttop(line2);
                }
                StreamReader rd = new StreamReader(@"highscore.txt");
                string lowest="";
                while (!rd.EndOfStream)
                {
                    lowest = rd.ReadLine();
                }
                rd.Close();
                string []split = lowest.Split('\t');
                if (split.Length == 4)
                {
                    if (Int32.Parse( split[2]) < Int32.Parse(lblscore.Text))
                    {
                        string[] lines = File.ReadAllLines(@"highscore.txt");
                        File.WriteAllLines(@"highscore.txt", lines.Take(lines.Length - 1).ToArray());
                        File.AppendAllText(@"highscore.txt", txtname.Text + "\t" + lbltopic.Text + "\t" + lblscore.Text + "\t" + lbltime.Text + Environment.NewLine);
                        string[] lines2 = File.ReadAllLines(@"highscore.txt");
                        sorttop(lines2);
                        return;
                    }

                }

                //arrange the list 

               


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            check_TOP();
            this.pictureBox1 = null;
            this.pictureBox2= null;
            this.pictureBox3= null;
            this.pictureBox4= null;
            this.pictureBox5= null;
            this.Controls.Clear();
            this.Dispose();
            
        }
        private void sorttop(string[] line)
        {
            if (line.Length == 1)
                return;
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

            var ssort = a.OrderByDescending(y => Int32.Parse(y[2]));
            if (File.Exists(@"highscore.txt"))
            {
                StreamWriter wt = new StreamWriter(@"highscore.txt");
                foreach (var lm in ssort)
                {
                    foreach (var item in lm)
                    {
                        if (item == lm[lm.Length - 1])
                        {
                            wt.Write(item);

                        }
                        else
                        {
                            wt.Write(item + "\t");
                        }
                    }
                    wt.WriteLine();
                }
                wt.Close();
                var lines = File.ReadAllLines(@"highscore.txt");
                File.WriteAllLines(@"highscore.txt", lines.Take(lines.Length).ToArray());
            }
            }
        private void lcor2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
