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
    public partial class TopicItem : UserControl
    {
        public TopicItem()
        {
            InitializeComponent();
        }

        private void TopicItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"playing.txt"))
            {
                StreamWriter writer = new StreamWriter("playing.txt");
                writer.Write(label1.Text);
                writer.Close();
            }
        }
    }
}
