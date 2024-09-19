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
    public partial class KalkulackaLepsi : Form
    {
        public KalkulackaLepsi()
        {
            InitializeComponent();

        }

        private void KalkulackaLepsi_Load(object sender, EventArgs e)
        {

        }

        private void bVypocitej_Click(object sender, EventArgs e)
        {
            string znak = cbZnak.Text;
            double cislo1 = Convert.ToDouble(nudCislo1.Value);
            double cislo2 = Convert.ToDouble(nudCislo2.Value);
            if (znak == "+")
                lVysledek.Text = (cislo1 + cislo2).ToString();
            else if (znak == "-")
                lVysledek.Text = (cislo1 - cislo2).ToString();
            else if (znak == "*")
                lVysledek.Text = (cislo1 * cislo2).ToString();
            else if (znak == "/")
                if (cislo2 == 0)
                {
                    MessageBox.Show("Nelze dělit nulou");
                    lVysledek.Text = "";
                }
                else
                    lVysledek.Text = (cislo1 / cislo2).ToString();
        }
    }
}
