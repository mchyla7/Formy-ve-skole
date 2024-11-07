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
    public partial class KamenNeboNuzkyNeboPapir : Form
    {

        double PocetVyherJa;
        double PocetVyherPC;
        bool stejneOtaznik = false;
        string KamenNuzkyPapir;
        string CoToJe;
        Random generator = new Random();
        double kamen;
        double papir;
        double nuzky;

        public KamenNeboNuzkyNeboPapir()
        {
            InitializeComponent();
            pbVysledekNuzky.Visible = false;
            pbVysledekKamen.Visible = false;
            pbVysledekPapir.Visible = false;
            pbKamenBlur.Visible = false;
            pbNuzkyBlur.Visible = false;
            pbPapirBlur.Visible = false;
            pbBackgroundKamen.Visible = false;
            pbBackgroundNuzky.Visible = false;
            pbBackgroundPapir.Visible = false;
        }

        private void KamenNeboNuzky_Load(object sender, EventArgs e)
        {
            int KamenNuzkyPapir = generator.Next(1, 4);
            if (KamenNuzkyPapir == 1)
            {
                CoToJe = "Kamen";
            }
            else if (KamenNuzkyPapir == 2)
            {
                CoToJe = "Nuzky";
            }
            else if (KamenNuzkyPapir == 3)
            {
                CoToJe = "Papir";
            }
        }

        private void pbKamen_Click(object sender, EventArgs e)
        {
            pbPozadi.Image = pbBackgroundKamen.Image;
            pbKamenBlur.Visible = true;
            pbNuzkyBlur.Visible = false;
            pbPapirBlur.Visible = false;
            kamen++;
            papir = 0;
            nuzky = 0;
            if (kamen > 5)
            {
                    CoToJe = "Papir"; 
            }

            if (CoToJe == "Kamen")
            {
                lKdoVyhral.Text = "Remíza";
                pbVysledekNuzky.Visible = false;
                pbVysledekKamen.Visible = true;
                pbVysledekPapir.Visible = false;
            }
            else if (CoToJe == "Nuzky")
            {
                lKdoVyhral.Text = "Vyhrál jste";
                PocetVyherJa = PocetVyherJa + 1;
                lPocetVyherJA.Text = PocetVyherJa.ToString();
                pbVysledekNuzky.Visible = true;
                pbVysledekKamen.Visible = false;
                pbVysledekPapir.Visible = false;

            }
            else if (CoToJe == "Papir")
            {
                lKdoVyhral.Text = "Prohrál jste";
                PocetVyherPC = PocetVyherPC + 1;
                lPocetVyherPC.Text = PocetVyherPC.ToString();
                pbVysledekNuzky.Visible = false;
                pbVysledekKamen.Visible = false;
                pbVysledekPapir.Visible = true;
            }
            int KamenNuzkyPapir = generator.Next(1, 4);
            if (KamenNuzkyPapir == 1)
            {
                CoToJe = "Kamen";
            }
            else if (KamenNuzkyPapir == 2)
            {
                CoToJe = "Nuzky";
            }
            else if (KamenNuzkyPapir == 3)
            {
                CoToJe = "Papir";
            }
            

        }

        private void pbNuzky_Click(object sender, EventArgs e)
        {
            pbPozadi.Image = pbBackgroundNuzky.Image;
            pbKamenBlur.Visible = false;
            pbNuzkyBlur.Visible = true;
            pbPapirBlur.Visible = false;
            nuzky++;
            kamen = 0;
            papir = 0;
            if (nuzky > 5)
            {
                CoToJe = "Kamen";
            }
            if (CoToJe == "Kamen")
            {
                lKdoVyhral.Text = "Prohrál jste";
                PocetVyherPC = PocetVyherPC + 1;
                lPocetVyherPC.Text = PocetVyherPC.ToString();
                pbVysledekNuzky.Visible = false;
                pbVysledekKamen.Visible = true;
                pbVysledekPapir.Visible = false;
            }
            else if (CoToJe == "Nuzky")
            {
                lKdoVyhral.Text = "Remíza";
                pbVysledekNuzky.Visible = true;
                pbVysledekKamen.Visible = false;
                pbVysledekPapir.Visible = false;
            }
            else if (CoToJe == "Papir")
            {
                lKdoVyhral.Text = "Vyhrál jste";
                PocetVyherJa = PocetVyherJa + 1;
                lPocetVyherJA.Text = PocetVyherJa.ToString();
                pbVysledekNuzky.Visible = false;
                pbVysledekKamen.Visible = false;
                pbVysledekPapir.Visible = true;
            }
            int KamenNuzkyPapir = generator.Next(1, 4);
            if (KamenNuzkyPapir == 1)
            {
                CoToJe = "Kamen";
            }
            else if (KamenNuzkyPapir == 2)
            {
                CoToJe = "Nuzky";
            }
            else if (KamenNuzkyPapir == 3)
            {
                CoToJe = "Papir";
            }
        }

        private void pbPapir_Click(object sender, EventArgs e)
        {
            pbPozadi.Image = pbBackgroundPapir.Image;
            pbKamenBlur.Visible = false;
            pbNuzkyBlur.Visible = false;
            pbPapirBlur.Visible = true;
            papir++;
            nuzky = 0;
            kamen = 0;
            if (papir > 5)
            {
                CoToJe = "Nuzky";
            }
            if (CoToJe == "Kamen")
            {
                lKdoVyhral.Text = "Vyhrál jste";
                PocetVyherJa = PocetVyherJa + 1;
                lPocetVyherJA.Text = PocetVyherJa.ToString();
                pbVysledekNuzky.Visible = false;
                pbVysledekKamen.Visible = true;
                pbVysledekPapir.Visible = false;
            }
            else if (CoToJe == "Nuzky")
            {
                lKdoVyhral.Text = "Prohrál jste";
                PocetVyherPC = PocetVyherPC + 1;
                lPocetVyherPC.Text = PocetVyherPC.ToString();
                pbVysledekNuzky.Visible = true;
                pbVysledekKamen.Visible = false;
                pbVysledekPapir.Visible = false;
            }
            else if (CoToJe == "Papir")
            {
                lKdoVyhral.Text = "Remíza";
                pbVysledekNuzky.Visible = false;
                pbVysledekKamen.Visible = false;
                pbVysledekPapir.Visible = true;
            }
            int KamenNuzkyPapir = generator.Next(1, 4);
            if (KamenNuzkyPapir == 1)
            {
                CoToJe = "Kamen";
            }
            else if (KamenNuzkyPapir == 2)
            {
                CoToJe = "Nuzky";
            }
            else if (KamenNuzkyPapir == 3)
            {
                CoToJe = "Papir";
            }
        }

        private void bNovaHra_Click(object sender, EventArgs e)
        {
            PocetVyherPC = 0;
            PocetVyherJa = 0;
            lPocetVyherJA.Text = PocetVyherJa.ToString();
            lPocetVyherPC.Text = PocetVyherPC.ToString();
            
        }

        private void lJá_Click(object sender, EventArgs e)
        {

        }

    }
}
