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
    public partial class select_topic : UserControl
    {
        public select_topic()
        {
            InitializeComponent();
            if(Directory.Exists(@"data/"))
            { 
                DirectoryInfo di = new DirectoryInfo(@"data/");           
                List<string> list = new List<string>();
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    list.Add(dir.Name);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    TopicItem item = new TopicItem();
                    item.label1.Text = list[i];
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
           
        }

        private void select_topic_Load(object sender, EventArgs e)
        {

        }
        protected virtual bool DoubleBuffered { get; set; }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
