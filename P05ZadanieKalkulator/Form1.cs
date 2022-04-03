using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05ZadanieKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }



        private void btnPrzycisk_Click(object sender, EventArgs e)
        {
            // Button b = (Button)sender;
            // txtWyswietlacz.Text += b.Text;

            //((Control)sender).t

            txtWyswietlacz.Text += ((Button)sender).Text;
        }

        private void btnRownaSie_Click(object sender, EventArgs e)
        {
            KalkulatorRownan kr = new KalkulatorRownan();

            double wynik = kr.WykonajOperacje(txtWyswietlacz.Text);
            txtWyswietlacz.Text = Convert.ToString(wynik);
            

        }
    }
}
