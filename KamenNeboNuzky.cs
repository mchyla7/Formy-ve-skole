﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class KamenNeboNuzky : Form
    {

        double PocetVyherJa;
        double PocetVyherPC;
        bool stejneOtaznik = false;
        string KamenNuzkyPapir;
        string CoToJe;
        Random generator = new Random();

        public KamenNeboNuzky()
        {
            InitializeComponent();
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
            if (CoToJe == "Kamen")
            {
                lKdoVyhral.Text = "Remíza";
            }
            else if (CoToJe == "Nuzky")
            {
                lKdoVyhral.Text = "Vyhrál jste";
                PocetVyherJa = PocetVyherJa + 1;
                lPocetVyherJA.Text = PocetVyherJa.ToString();
            }
            else if (CoToJe == "Papir")
            {
                lKdoVyhral.Text = "Prohrál jste";
                PocetVyherPC = PocetVyherPC + 1;
                lPocetVyherPC.Text = PocetVyherPC.ToString();
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
            if (CoToJe == "Kamen")
            {
                lKdoVyhral.Text = "Prohrál jste";
                PocetVyherPC = PocetVyherPC + 1;
                lPocetVyherPC.Text = PocetVyherPC.ToString();
            }
            else if (CoToJe == "Nuzky")
            {
                lKdoVyhral.Text = "Remíza";
            }
            else if (CoToJe == "Papir")
            {
                lKdoVyhral.Text = "Vyhrál jste";
                PocetVyherJa = PocetVyherJa + 1;
                lPocetVyherJA.Text = PocetVyherJa.ToString();
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
            if (CoToJe == "Kamen")
            {
                lKdoVyhral.Text = "Vyhrál jste";
                PocetVyherJa = PocetVyherJa + 1;
                lPocetVyherJA.Text = PocetVyherJa.ToString();
            }
            else if (CoToJe == "Nuzky")
            {
                lKdoVyhral.Text = "Prohrál jste";
                PocetVyherPC = PocetVyherPC + 1;
                lPocetVyherPC.Text = PocetVyherPC.ToString();
            }
            else if (CoToJe == "Papir")
            {
                lKdoVyhral.Text = "Remíza";
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
    }
}
