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
    public partial class _Stopky : Form
    {
        int s = 0;
        bool stop = true;

        public _Stopky()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
        }

        private void _Stopky_Load(object sender, EventArgs e)
        {

        }

        private void lCas_Click(object sender, EventArgs e)
        {

        }

        private void lStopky_Click(object sender, EventArgs e)
        {
            if(stop)
            {
                timer2.Stop();
            }
            else
            {
                s = 0;
                timer2.Start();
            }
            stop = !stop;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s++;
            TimeSpan t = TimeSpan.FromSeconds(s);
            string vystup = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds);
            lStopky.Text = vystup;

        }
    }
}
