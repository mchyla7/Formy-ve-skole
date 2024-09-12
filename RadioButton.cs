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
    public partial class RadioButton : Form

    {

        string text;

        public RadioButton()
        {
            InitializeComponent();
        }

        private void rbAno_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Ano";
        }

        private void rbNe_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Ne";
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            text = "Jednička";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            text = "Dvojka";
        }

        private void button1nebo2_Click(object sender, EventArgs e)
        {
            label2.Text = text;
        }

    }
}
