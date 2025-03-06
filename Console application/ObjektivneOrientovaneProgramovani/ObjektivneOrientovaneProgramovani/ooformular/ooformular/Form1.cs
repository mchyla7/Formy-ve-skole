using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ooformular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hodnoty.hodnota += textBox1.Text + Environment.NewLine;

            Form2 form2 = new Form2(); // Vytvoření nového formuláře

            this.Hide();

            form2.ShowDialog();
            // this.Close();
        }
    }
}
