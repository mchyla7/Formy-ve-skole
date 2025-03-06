using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oopPracovnici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string text = "{0} {1} {2}", informace.jmeno, informace.prijmeni  informace.vek;
            textBox1.Text = text;
        }

    }
}
