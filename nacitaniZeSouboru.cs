using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class nacitaniZeSouboru : Form
    {
        public nacitaniZeSouboru()
        {
            InitializeComponent();
        }

        private void bOtevrit_Click(object sender, EventArgs e)
        {
            string[] data;
            openFileDialog1.ShowDialog();
            string soubor = openFileDialog1.FileName;
            try
            {
                data = File.ReadAllLines(soubor);
            }
            catch
            {
                MessageBox.Show("Soubor se nepodařilo otevřít");
                return;
            }

            double[] cisla = new double[data.Length];
            double cislo;
            for (int i = 0; i < data.Length; i++)
            {
                if (!double.TryParse(data[i], out cislo))
                {
                    MessageBox.Show("Chyba v datech souboru");
                    return;
                }
                cisla[i] = double.Parse(data[i]);
            }
            Array.Sort(cisla);
                        string tisk = "";
            foreach (double x in cisla )
                tisk += x + ";";
            tisk = tisk.Substring(0, tisk.Length - 1);//odstraní poslední "; "
            tbText.Text = tisk;
         
        }
        private void bKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
