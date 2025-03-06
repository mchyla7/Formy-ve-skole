using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oopPracovnici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            informace.jmeno += tbJmeno.Text;
            informace.prijmeni += tbPrijmeni.Text;
            informace.vek = (int)nUDVek.Value;

            Form2 form2 = new Form2();

            this.Hide();

            form2.ShowDialog();

        }
    }
}
