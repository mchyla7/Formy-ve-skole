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
    public partial class mailsss : Form
    {
        private List<string> serazeneZaznamy;

        public mailsss()
        {
            InitializeComponent();
        }

        private void mailsss_Load(object sender, EventArgs e)
        {
            // Zadání

            // Vytvořte formulářovou aplikaci. ✔
            // Bude pracovat se souborem mail.txt. ✔
            // Zkontroluje, zda obsahuje záznamy ve struktuře text.text@doména. ✔
            // Soubor výsledky kontroly zobrazí uživateli a zeptá se, zda vyhovující záznamy má zpravovat do výstupu. ✔
            // Zeptá se na jméno souboru. ✔
            // Program vytvoří nový soubor. ✔
            // Záznamy budou seřazené podle příjmení.
            // Každý záznam bude na samostatném řádku
            // Záznam: příjmení jméno mail
            // adam.fojtik@mendelova-stredni.cz

        }

        private void bOpen_Click(object sender, EventArgs e)
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
                MessageBox.Show("Soubor nebyl nalezen");
                return;
            }

            string[] jednotliveEmaily = data.SelectMany(line => line.Split(';')).Where(email => !string.IsNullOrEmpty(email)).ToArray();
            List<string> funkcniEmaily = new List<string>();

            foreach (string email in jednotliveEmaily)
            {
                string[] parts = email.Split('@');
                if (parts.Length == 2)
                {
                    string[] nameParts = parts[0].Split('.');
                    if (nameParts.Length == 2 && !string.IsNullOrEmpty(nameParts[0]) && !string.IsNullOrEmpty(nameParts[1]) && parts[1].Contains('.'))
                    {
                        funkcniEmaily.Add(email);
                    }
                }
                else
                {
                    MessageBox.Show("Email " + email + " není ve správném formátu");
                }
            }

            MessageBox.Show("Emaily byly načteny a jsou zkontrolovány");
            richTextBox1.Text = string.Join(Environment.NewLine, funkcniEmaily);

            serazeneZaznamy = funkcniEmaily
                .Select(email => new { Email = email, Jmeno = email.Split('@')[0].Split('.')[0], Prijmeni = email.Split('@')[0].Split('.')[1] })
                .OrderBy(zaznam => zaznam.Prijmeni)
                .Select(zaznam => $"{zaznam.Jmeno} {zaznam.Prijmeni} {zaznam.Email}")
                .ToList();
        }

        private void bUlozit_Click(object sender, EventArgs e)
        {
            string jmenoSouboru = tbJmenoSouboru.Text;
            saveFileDialog1.DefaultExt = "txt"; // přípona
            saveFileDialog1.FileName = jmenoSouboru;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);// přednastavena cesta
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files (*.*)|*.*"; // možné typy souborů
            saveFileDialog1.FilterIndex = 1; // vybraný txt
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string cestaUlozeni = saveFileDialog1.FileName;
            File.WriteAllText(cestaUlozeni, string.Join(Environment.NewLine, serazeneZaznamy));
            MessageBox.Show("Emaily byly uloženy do souboru " + cestaUlozeni);
        }
    }
}