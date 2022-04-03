using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNacisnijMnie_Click(object sender, EventArgs e)
        {
            string s = "ala ma kota";

            s = txtImie.Text;

            MessageBox.Show(s);




        }
    }
}
