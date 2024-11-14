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
    public partial class PraceSDatumem : Form
    {
        public PraceSDatumem()
        {
            InitializeComponent();
        }

        private void PraceSDatumem_Load(object sender, EventArgs e)
        {

            DateTime nyni = DateTime.Now;

            int den = nyni.Day;
            int mesic = nyni.Month;
            int rok = nyni.Year;
            int hodina = nyni.Hour;
            int minuta = nyni.Minute;
            int sekudna = nyni.Second;

            label1.Text = ("Den je " + den);

            label2.Text = ("Měsíc je " + mesic);
            label3.Text = ("Rok je " + rok);
            label4.Text = ("Hodina je " + hodina);
            label5.Text = ("Minuta je " + minuta);
            label6.Text = ("Sekund je " + sekudna);

            // Zítřejší a dnešní den

            DateTime dnes = DateTime.Now;

            label7.Text = ("Dnes je " + dnes.ToShortDateString() + ".");
            label8.Text = ("Dnes je " + dnes.ToLongDateString() + ".");

            DateTime zitra = dnes.AddDays(1);

            label9.Text = ("Dnes je " + dnes.ToShortDateString() + ".");
            label10.Text = ("Zítra bude " + zitra.ToShortDateString() + ".");
        }
    }
}
