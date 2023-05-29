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
    public partial class InGame : UserControl
    {
        public List<string> namequest = new List<string>();
        public List<Image> imagesquest = new List<Image>();
        public int count = 0;
        public int [] result = new int[5];
        public InGame()
        {
            InitializeComponent();
           
            if (File.Exists("playing.txt"))
            {
                StreamReader rd = new StreamReader("playing.txt");
                string topic = rd.ReadLine();
                rd.Close();
                DirectoryInfo di = new DirectoryInfo(@"data/"+ topic +"/");
                List <string> name = new List<string>();
                List <Image> images = new List<Image>();

                foreach (FileInfo fi in di.GetFiles())
                {
                   

                    name.Add(Path.GetFileNameWithoutExtension(fi.Name));
                    
                    images.Add(Image.FromFile(fi.FullName));
                }
                lblnum.Text = name[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                pictureBox1.Image= images[0];
                
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

                    //end game here
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
                            // end game here
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
    }
}
