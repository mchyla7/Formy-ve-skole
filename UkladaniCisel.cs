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
    public partial class UkladaniCisel : Form
    {
        float pocet = 0;
        static List<float> cisla = new List<float>();
        
        public UkladaniCisel()
        {
            InitializeComponent();
        }

        private void bPridatCislo_Click(object sender, EventArgs e)
        {
            pocet = pocet + 1;
            lPocetCiselReal.Text = pocet.ToString();
            
            float cislo;
            if (float.TryParse(tbCislo.Text, out cislo))
            {
                cisla.Add(cislo);
            }
            else {
                MessageBox.Show("Nezadal jsi číslo");
                pocet = pocet - 1;
                lPocetCiselReal.Text = pocet.ToString();
            }
        }

        private void bVymazatCisla_Click(object sender, EventArgs e)
        {
            pocet = 0;
            lPocetCiselReal.Text = pocet.ToString(); 
            cisla.Clear();
        }

        private void bUlozit_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt"; // přípona
            saveFileDialog1.OverwritePrompt = true; // zobrazí upozornění že přepíše existující soubor
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// přednastavena cesta
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*"; // možné typy souborů
            saveFileDialog1.FilterIndex = 1; // vybraný txt
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string cestaUlozeni = saveFileDialog1.FileName.ToString();
            
            if (rbOddelenoDvojteckou.Checked == true)
            {
                string text = "";
                foreach (int cislo in cisla)
                {
                    text = text + cislo + ":";
                }
                text = text.Remove(text.Length - 1);
                File.WriteAllText(cestaUlozeni, text);
            }
            else if (rbOddelenoTab.Checked == true)
            {
                string text = "";
                foreach (int cislo in cisla)
                {
                    text = text + cislo + "\t";
                }
                text = text.Remove(text.Length - 1);
                File.WriteAllText(cestaUlozeni, text);
            }
            else if (rbPodSebou.Checked == true)
            {
                string text = "";
                foreach (int cislo in cisla)
                {
                    text = text + cislo + "\n";
                }
                text = text.Remove(text.Length - 1);
                File.WriteAllText(cestaUlozeni, text);
            }

        }
    }
}
