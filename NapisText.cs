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
    public partial class NapisText : Form
    {
        public NapisText()
        {
            InitializeComponent();
            rtbVstup.Multiline = true;
            rtbVstup.ScrollBars = ScrollBars.Vertical;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.OverwritePrompt = true;

            saveFileDialog1.ShowDialog();
            rtbVstup.Clear();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, rtbVstup.Text);
            MessageBox.Show("Uloženo do souboru " + saveFileDialog1.FileName);
        }
    }
}
