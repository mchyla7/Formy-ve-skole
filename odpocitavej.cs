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
    public partial class odpocitavej : Form
    {
        int cas = 0;

        public odpocitavej()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void odpocitavej_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cas++;
            label1.Text = cas.ToString();
            
        }
    }
}
