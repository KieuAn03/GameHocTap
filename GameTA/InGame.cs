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
using GameTA;
using System.Threading;
namespace GameTA
{
    
    public partial class InGame : UserControl
    {
        public List<string> namequest = new List<string>();
        public List<Image> imagesquest = new List<Image>();
        public int count = 0;
        public int [] result = new int[5];
        public int second = 0;
        public int endgame { get; set; }
        public InGame()
        {
            InitializeComponent();
            timer1.Start();
            axWindowsMediaPlayer2.Visible = false;
            result1.Visible = false;
            btnendgame.Visible = false;
            if (File.Exists(@"play/playing.txt"))
            {

                StreamReader rd = new StreamReader(@"play/playing.txt");
                string topic = rd.ReadLine();
                rd.Close();
                result1.lbltopic.Text = topic;
                rd = null;
                DirectoryInfo di = new DirectoryInfo(@"data/"+ topic +"/");
                List <string> name = new List<string>();
                List <Image> images = new List<Image>();

                foreach (FileInfo fi in di.GetFiles())
                {
                    name.Add(Path.GetFileNameWithoutExtension(fi.Name));

                    images.Add(Image.FromFile(fi.FullName));
                }
                di = null;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                
                
                int len=images.Count;
                List<int> randomList = new List<int>();
                Random a = new Random();
                for (int i = 0; randomList.Count <len; i++)
                {
                    int MyNumber = a.Next(len);
                    if (!randomList.Contains(MyNumber))
                        randomList.Add(MyNumber);
                }             
                for (int i = 0; i < 5; i++)
                {
                    namequest.Add(name[randomList[i]]);
                    imagesquest.Add(images[randomList[i]]);
                }
                pictureBox1.Image = imagesquest[0];
                lblnum.Text = (count +1).ToString();
                name.Clear();
                name = null; 
                images.Clear();
                images = null;
                
                
            }
        }

        private void NewNumber(List<int> randomList, int len)
        {
            
        }
        private void InGame_Load(object sender, EventArgs e)
        {

        }
        protected virtual bool DoubleBuffered { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (count ==5)
                {

                    axWindowsMediaPlayer2.Visible = false;
                    return;
                   
                }
                
                if (textBox1.Text == namequest[count])
                    {
                        lblscore.Text = (Int32.Parse(lblscore.Text) + 20).ToString();
                        result[count] = 1;
                        
                        //check box 1 check
                        count++;
                        if (count == 5)
                        {
                        timer1.Stop();

                        result1.lblscore.Text = lblscore.Text ;
                        axWindowsMediaPlayer2.Visible = true;
                        axWindowsMediaPlayer2.URL = @"endgame.mp4";
                        axWindowsMediaPlayer2.settings.autoStart = true;
                        axWindowsMediaPlayer2.settings.setMode("loop", true);
                        btnendgame.Visible = true;
                    }
                        else
                        {
                        textBox1.Text = "";
                        pictureBox1.Image = imagesquest[count];
                        }

                    }
                    else
                    {
                        result[count] = 0;
                        count++;
                        if (count == 5)
                        {
                        timer1.Stop();
                        result1.lblscore.Text = lblscore.Text ;
                        axWindowsMediaPlayer2.Visible = true;
                        axWindowsMediaPlayer2.URL = @"endgame.mp4";
                        axWindowsMediaPlayer2.settings.autoStart = true;
                        axWindowsMediaPlayer2.settings.setMode("loop", true);
                        btnendgame.Visible = true;
                        //end game here
                    }
                        else
                        {
                        textBox1.Text = "";
                        pictureBox1.Image = imagesquest[count];
                        }

                    }

                lblnum.Text = (count + 1).ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Visible=false;
            //to the other
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Visible = false;
        }

        private void btnendgame_Click(object sender, EventArgs e)
        {
            endgame = 0;
            axWindowsMediaPlayer2.Dispose();
            initialresult();
            timer1.Dispose();
            result1.Visible = true;
            imagesquest.Clear();
            imagesquest = null;
            namequest = null;
            endgame = 1;
        }
        private void initialresult()
        {
            result1.pictureBox1.BackgroundImage = imagesquest[0];
            result1.pictureBox2.BackgroundImage = imagesquest[1];
            result1.pictureBox3.BackgroundImage = imagesquest[2];
            result1.pictureBox4.BackgroundImage = imagesquest[3];
            result1.pictureBox5.BackgroundImage = imagesquest[4];
            result1.lbltime.Text = lbltime.Text;
            if(result[0] == 1)
            {
                result1.pcheck1.BackgroundImage = Properties.Resources.correct;
            }
            else
            {
                result1.pcheck1.BackgroundImage= Properties.Resources.wrong;
                result1.lcor1.Text = namequest[0];
                result1.lcor1.Visible = true;
            }
            if (result[1] == 1)
            {
                result1.pcheck2.BackgroundImage = Properties.Resources.correct;
            }
            else
            {
                result1.pcheck2.BackgroundImage = Properties.Resources.wrong;
                result1.lcor2.Text = namequest[1];
                result1.lcor2.Visible = true;
            }
            if (result[2] == 1)
            {
                result1.pcheck3.BackgroundImage = Properties.Resources.correct;
            }
            else
            {
                result1.pcheck3.BackgroundImage = Properties.Resources.wrong;
                result1.lcor3.Text = namequest[2];
                result1.lcor3.Visible = true;
            }
            if (result[3] == 1)
            {
                result1.pcheck4.BackgroundImage = Properties.Resources.correct;
            }
            else
            {
                result1.pcheck4.BackgroundImage = Properties.Resources.wrong;
                result1.lcor4.Text = namequest[3];
                result1.lcor4.Visible = true;

            }
            if (result[4] == 1)
            {
                result1.pcheck5.BackgroundImage = Properties.Resources.correct;
            }
            else
            {
                result1.pcheck5.BackgroundImage = Properties.Resources.wrong;
                result1.lcor5.Text = namequest[4];
                result1.lcor5.Visible = true;

            }
        }
        private void result1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (second++).ToString() +" s";
        }

        private void result1_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }

        private void InGame_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (endgame == 1)
            {
                this.Dispose();
            }
            
        }

        private void InGame_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
