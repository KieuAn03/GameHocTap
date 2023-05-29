using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTA
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void lbldata_Click(object sender, EventArgs e)
        {
            Data dt = new Data();
            this.Parent.Controls.Add(dt);
            dt.Dock = DockStyle.Fill;
            dt.BringToFront();
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
