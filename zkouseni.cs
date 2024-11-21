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
        double vysledek = 0;
        int max;
        int min;
        int count = 1;
        int pocetPrikladu = 0;
        int spravne = 0;
        int spatne = 0;
        int s = 0;
        

        public zkouseni()
        {
            InitializeComponent();
            pPriklady.Visible = false;
            pVysledky.Visible = false;
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
            lSpravneSpatne.Text = "";
            count = 1;
            spravne = 0;
            spatne = 0;
            s = 0;
            timer1.Interval = 1000;
            
            pPriklady.Visible = true;
            pZadavani.Visible = false;
            pocetPrikladu = Convert.ToInt32(nudPocetPrikladu.Value);
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
                vysledek = (cislo1 * cislo2);
            }
            else if (znamenko == "Scitani")
            {
                lZnamenko.Text = "+";
                vysledek = (cislo1 + cislo2);
            }
            else if (znamenko == "odcitani")
            {
                lZnamenko.Text = "-";
                vysledek = (cislo1 - cislo2);
            }
            else if (znamenko == "Vsechno")
            {
                if (randomZnamenko == 1)
                {
                    lZnamenko.Text = "+";
                    vysledek = (cislo1 + cislo2);
                }
                else if (randomZnamenko == 2)
                {
                    lZnamenko.Text = "-";
                    vysledek = (cislo1 - cislo2);

                }
                else if (randomZnamenko == 3)
                {
                    lZnamenko.Text = "*";
                    vysledek = (cislo1 * cislo2);

                }
                else if (randomZnamenko == 4)
                {
                    lZnamenko.Text = "/";
                    vysledek = (cislo1 / cislo2);

                }
            }



        }

        private void bPal_Click(object sender, EventArgs e)
        {
            bool skip = false;
            double cislo = 0;

            if (double.TryParse(tbVysledek.Text, out cislo))
            {
                if (cislo == vysledek)
                    //if (double.Parse(vysledek) === nudVysledek)
                {
                    spravne = spravne + 1;
                    lSpravneSpatne.Text = "Spravně";
                    skip = true;
                    tbVysledek.Clear();
                }
                else
                {
                    spatne = spatne + 1;
                    lSpravneSpatne.Text = "Špatně";
                    skip = true;
                    tbVysledek.Clear();
                }
                
                if (count == pocetPrikladu)
                {
                    pPriklady.Visible = false;
                    pVysledky.Visible = true;
                    lPocetDobre.Text = "Počet dobře je " + spravne;
                    lPocetSpatne.Text = "Počet špatně je " + spatne;
                    timer1.Stop();
                }
                else 
                {

                    if (skip == true)
                    {
                        skip = false;

                        Random generator = new Random();
                        int cislo1 = generator.Next(min, max);
                        int cislo2 = generator.Next(min, max);
                        int randomZnamenko = generator.Next(1, 4);
                        lPrvniCislo.Text = cislo1.ToString();
                        lDruheCislo.Text = cislo2.ToString();
                        if (znamenko == "Nasobeni")
                        {
                            lZnamenko.Text = "*";
                            vysledek = (cislo1 * cislo2);
                        }
                        else if (znamenko == "Scitani")
                        {
                            lZnamenko.Text = "+";
                            vysledek = (cislo1 + cislo2);
                        }
                        else if (znamenko == "odcitani")
                        {
                            lZnamenko.Text = "-";
                            vysledek = (cislo1 - cislo2);
                        }
                        else if (znamenko == "Vsechno")
                        {
                            if (randomZnamenko == 1)
                            {
                                lZnamenko.Text = "+";
                                vysledek = (cislo1 + cislo2);
                            }
                            else if (randomZnamenko == 2)
                            {
                                lZnamenko.Text = "-";
                                vysledek = (cislo1 - cislo2);

                            }
                            else if (randomZnamenko == 3)
                            {
                                lZnamenko.Text = "*";
                                vysledek = (cislo1 * cislo2);

                            }
                            else if (randomZnamenko == 4)
                            {
                                lZnamenko.Text = "/";
                                vysledek = (cislo1 / cislo2);

                            }

                        }
                    }
                    count++;
                }
            }
        }

        private void bLetsGoBack_Click(object sender, EventArgs e)
        {
            pVysledky.Visible = false;
            pZadavani.Visible = true;
            timer1.Start();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            TimeSpan t = TimeSpan.FromSeconds(s);
            string vystup = string.Format("{0:D2}h:{1:D2}m:{2:D2}.{3:D2}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            lTrvaloTiTo.Text = vystup;
        }
    }
}
