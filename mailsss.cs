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
        public mailsss()
        {
            InitializeComponent();
        }

        private void mailsss_Load(object sender, EventArgs e)
        {
            // Zadání

            // Vytvořte formulářovou aplikaci.
            // Bude pracovat se souborem mail.txt.
            // Zkontroluje, zda obsahuje záznamy ve struktuře text.text@doména.
            // Soubor výsledky kontroly zobrazí uživateli a zeptá se, zda vyhovující záznamy má zpravovat do výstupu.
            // Zeptá se na jméno souboru.
            // Program vytvoří nový soubor.
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
            richTextBox1.Text = jednotliveEmaily.ToString();
        }
    }
}
