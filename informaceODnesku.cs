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
    public partial class informaceODnesku : Form
    {
        public informaceODnesku()
        {
            InitializeComponent();
        }

        private void informaceODnesku_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = Convert.ToDateTime("2025.1.31");
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

            DateTime nyni = dateTimePicker1.Value;

            label1.Text = nyni.ToString();
            label2.Text = nyni.Day.ToString();
            label3.Text = nyni.Month.ToString();
            label4.Text = nyni.Year.ToString();


            label5.Text = nyni.Hour + ":" + nyni.Minute + ":" + nyni.Second; 

        }
    }
}
