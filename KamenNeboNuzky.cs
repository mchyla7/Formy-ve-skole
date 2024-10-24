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
    public partial class KamenNeboNuzky : Form
    {

        double PocetVyherJa;
        double PocetVyherPC;
        bool stejneOtaznik = false;
        string VyberUzivatele;
        string KamenNuzkyPapir;
        string CoToJe;

        public KamenNeboNuzky()
        {
            InitializeComponent();
        }

        private void KamenNeboNuzky_Load(object sender, EventArgs e)
        {
            Random generator = new Random();
            int KamenNuzkyPapir = generator.Next(1, 3);
            if (KamenNuzkyPapir == 1)
            {
                CoToJe = "Kamen";
            }
            else if (KamenNuzkyPapir == 2)
            {
                CoToJe = "Nuzky";
            }
            else
            {
                CoToJe = "Kamen";
            }
        }

        public static void algoritmus
        {
            
        }

        private void pbKamen_Click(object sender, EventArgs e)
        {
            VyberUzivatele = "Kamen";
            if (CoToJe == "Kamen")
            {
                if (VyberUzivatele == KamenNuzkyPapir)
                {
                    lKdoVyhral.Text = "Remíza";
                }


            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
