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
            label1_Click(sender, e);
        }
        protected virtual bool DoubleBuffered { get; set; }
        private void TopicItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"play/"))
            {
                StreamWriter writer = new StreamWriter(@"play/playing.txt");
                writer.WriteLine(label1.Text);
                writer.Close();
                this.Controls.Clear();
                this.Parent.Parent.Controls.Remove(this.Parent);
            }
        }
    }
}
