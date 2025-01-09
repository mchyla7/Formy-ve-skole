using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

//! NEVIM

namespace WindowsFormsApplication1
{
    public partial class kontrolaEmailu : Form
    {
        public kontrolaEmailu()
        {
            InitializeComponent();
        }

        private void bKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bOtevrit_Click(object sender, EventArgs e)
        {
            string[] data;
            openFileDialog1.ShowDialog();
            string soubor = openFileDialog1.FileName;
            string emaily = " ";
            try
            {
                data = File.ReadAllLines(soubor);
            }
            catch
            {
                MessageBox.Show("Soubor se nepodařilo otevřít");
                return;
            }

                if (data.IndexOf('@') > 1)
                {
                    emaily = emaily + data + " ;";
                }
            }
            tbText.Text = emaily;
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

        }
    }
}
