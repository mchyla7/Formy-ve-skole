using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programko
{
    public partial class hadani : Form
    {
        int hadane_cislo;
        int pocitatdlo = 0;
        
        public hadani()

        {
            
            
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            decimal max1 = Math.Round(hornihranice.Value, 0);
            decimal min1 = Math.Round(dolnihranice.Value, 0);
            int max = Convert.ToInt32(max1);
            int min = Convert.ToInt32(min1);
            
            Random  r= new Random();
            hadane_cislo = r.Next(min, max);


        }

        private void buttonhadani_Click(object sender, EventArgs e)
        {
            pocitatdlo += 1;
            if (hadaciokenko.Text == hadane_cislo.ToString()) 
            {
                panel2.Visible = false;
                panel3.Visible = true;
                vyslednytext.Text = "uhodl jsi na " + pocitatdlo + " pokusů";
            }

        }

        private void buttonkonec_Click(object sender, EventArgs e)
        {
            if (ukoncit.Checked == true) Application.Exit();
            if (spustitznovu.Checked == true) 
            {
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }

        private void hadani_Load(object sender, EventArgs e)
        {

        }
    }
}
