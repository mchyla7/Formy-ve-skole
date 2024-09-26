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
    public partial class zkouseni : Form
    {
        string znamenko = "";

        public zkouseni()
        {
            InitializeComponent();
            pPriklady.Visible = false;
        }

        private void rbNasobeni_CheckedChanged(object sender, EventArgs e)
        {
            string znamenko = "Nasobeni";
        }

        private void rbScitani_CheckedChanged(object sender, EventArgs e)
        {
            string znamenko = "Scitani";
        }

        private void rbOdcitani_CheckedChanged(object sender, EventArgs e)
        {
            string znamenko = "Odcitani";
        }

        private void rbVse_CheckedChanged(object sender, EventArgs e)
        {
            string znamenko = "Vsechno";
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            pPriklady.Visible = true;
            pZadavani.Visible = false;
            decimal pocetPrikladu = nudPocetPrikladu.Value;
            decimal horniHranice = nudHorniHranice.Value;
            decimal dolniHranice = nudDolniHranice.Value;

            int max = Convert.ToInt32(horniHranice);
            int min = Convert.ToInt32(dolniHranice);

            Random generator = new Random();
            int cislo1 = generator.Next(min, max);
            int cislo2 = generator.Next(min, max);
            lPrvniCislo.Text = cislo1.ToString();
            lDruheCislo.Text = cislo2.ToString();
            if (znamenko == "Nasobeni")
            {
                lZnamenko.Text = "*";
                string vysledek = (cislo1 * cislo2).ToString();
            }



        }
    }
}
