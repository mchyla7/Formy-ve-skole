using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class hodiny : Form
    {
        public hodiny()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime nyni = DateTime.Now;
            label1.Text = nyni.Hour + ":" + nyni.Minute + ":" + nyni.Second;
        }
    }
}
