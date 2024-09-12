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
    public partial class Kalkulacka : Form
    {

        float znak;

        public Kalkulacka()
        {
            InitializeComponent();
        }

        private void rbSoucet_CheckedChanged(object sender, EventArgs e)
        {
            znak = 1;
        }

        private void rbSoucin_CheckedChanged(object sender, EventArgs e)
        {
            znak = 2;
        }

        private void bVysledek_Click(object sender, EventArgs e)
        {
            float cisloA;
            float cisloB;
            if (znak == 1)
            {
                if (!float.TryParse(tbA.Text, out cisloA) || !float.TryParse(tbB.Text, out cisloB))
                {
                    tbVysledek.Text = "Byla zadána nečíselná hodnota";
                    return;
                }
                else
                {
                    tbVysledek.Text = (cisloA + cisloB).ToString();
                }
            }
            else if (znak == 2)
            {   
                if (!float.TryParse(tbA.Text, out cisloA) || !float.TryParse(tbB.Text, out cisloB))
                {
                    tbVysledek.Text = "Byla zadána nečíselná hodnota";
                    return;
                }
                else
                {
                    tbVysledek.Text = (cisloA - cisloB).ToString();
                }
            }


        }

        private void Kalkulacka_Load(object sender, EventArgs e)
        {

        }
    }
}
