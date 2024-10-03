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
        string vysledek = "";
        int max;
        int min;

        public zkouseni()
        {
            InitializeComponent();
            pPriklady.Visible = false;
        }

        private void rbNasobeni_CheckedChanged(object sender, EventArgs e)
        {
            znamenko = "Nasobeni";
        }

        private void rbScitani_CheckedChanged(object sender, EventArgs e)
        {
            znamenko = "Scitani";
        }

        private void rbOdcitani_CheckedChanged(object sender, EventArgs e)
        {
            znamenko = "Odcitani";
        }

        private void rbVse_CheckedChanged(object sender, EventArgs e)
        {
            znamenko = "Vsechno";
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            pPriklady.Visible = true;
            pZadavani.Visible = false;
            decimal pocetPrikladu = nudPocetPrikladu.Value;
            decimal horniHranice = nudHorniHranice.Value;
            decimal dolniHranice = nudDolniHranice.Value;

            max = Convert.ToInt32(horniHranice);
            min = Convert.ToInt32(dolniHranice);

            Random generator = new Random();
            int cislo1 = generator.Next(min, max);
            int cislo2 = generator.Next(min, max);
            int randomZnamenko = generator.Next(1, 4);
            lPrvniCislo.Text = cislo1.ToString();
            lDruheCislo.Text = cislo2.ToString();
            if (znamenko == "Nasobeni")
            {
                lZnamenko.Text = "*";
                vysledek = (cislo1 * cislo2).ToString();
            }
            else if (znamenko == "Scitani")
            {
                lZnamenko.Text = "+";
                vysledek = (cislo1 + cislo2).ToString();
            }
            else if (znamenko == "odcitani")
            {
                lZnamenko.Text = "-";
                vysledek = (cislo1 - cislo2).ToString();
            }
            else if (znamenko == "Vsechno")
            {
                if (randomZnamenko == 1)
                {
                    lZnamenko.Text = "+";
                    vysledek = (cislo1 + cislo2).ToString();
                }
                else if (randomZnamenko == 2)
                {
                    lZnamenko.Text = "-";
                    vysledek = (cislo1 - cislo2).ToString();

                }
                else if (randomZnamenko == 3)
                {
                    lZnamenko.Text = "*";
                    vysledek = (cislo1 * cislo2).ToString();

                }
                else if (randomZnamenko == 4)
                {
                    lZnamenko.Text = "/";
                    vysledek = (cislo1 / cislo2).ToString();

                }
            }



        }

        private void bPal_Click(object sender, EventArgs e)
        {
            if (tbVysledek.Text == vysledek)
            {
                Random generator = new Random();
                int cislo1 = generator.Next(min, max);
                int cislo2 = generator.Next(min, max);
                int randomZnamenko = generator.Next(1, 4);
                lPrvniCislo.Text = cislo1.ToString();
                lDruheCislo.Text = cislo2.ToString();
                if (znamenko == "Nasobeni")
                {
                    lZnamenko.Text = "*";
                    vysledek = (cislo1 * cislo2).ToString();
                }
                else if (znamenko == "Scitani")
                {
                    lZnamenko.Text = "+";
                    vysledek = (cislo1 + cislo2).ToString();
                }
                else if (znamenko == "odcitani")
                {
                    lZnamenko.Text = "-";
                    vysledek = (cislo1 - cislo2).ToString();
                }
                else if (znamenko == "Vsechno")
                {
                    if (randomZnamenko == 1)
                    {
                        lZnamenko.Text = "+";
                        vysledek = (cislo1 + cislo2).ToString();
                    }
                    else if (randomZnamenko == 2)
                    {
                        lZnamenko.Text = "-";
                        vysledek = (cislo1 - cislo2).ToString();

                    }
                    else if (randomZnamenko == 3)
                    {
                        lZnamenko.Text = "*";
                        vysledek = (cislo1 * cislo2).ToString();

                    }
                    else if (randomZnamenko == 4)
                    {
                        lZnamenko.Text = "/";
                        vysledek = (cislo1 / cislo2).ToString();

                    }
                }
            }
        }
    }
}
