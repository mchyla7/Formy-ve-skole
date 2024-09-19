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
    public partial class Kalkulacka2 : Form
    {
        public Kalkulacka2()
        {
            InitializeComponent();

            cbVzdelani.SelectedIndex = 1;
            tbVypis.Multiline = true;
            tbVypis.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudVek_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bVypis_Click(object sender, EventArgs e)
        {
            string text = "Věk: " + nudVek.Value + Environment.NewLine;
            text += "Vzdělání: " + cbVzdelani.Text;
            tbVypis.Text = text;
        }

        private void tbVypis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
