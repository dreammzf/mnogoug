using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            trackBar1.Value = Circle.R;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Circle.R = trackBar1.Value;
        }

        private void trackBar1_Move(object sender, EventArgs e)
        {
            Circle.R = trackBar1.Value;
        }
    }
}
