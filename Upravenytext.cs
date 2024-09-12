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
    public partial class Upravenytext : Form
    {
        public Upravenytext()
        {
            InitializeComponent();
            tbVysledek.Enabled = false; // Uzamkne prvek pro zápis
            tbVysledek.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upravenytext_Load(object sender, EventArgs e)
        {

        }

        
    }
}
