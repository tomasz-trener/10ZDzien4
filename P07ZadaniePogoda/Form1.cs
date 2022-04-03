using P07ZadaniePogoda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07ZadaniePogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] miasta= File.ReadAllLines("Miasta.txt");
            foreach (var m in miasta)
                cbMiasta.Items.Add(m);

        }

        private void PodajTemerature()
        {
            ManagerPogody mp = new ManagerPogody();
            int temp = mp.PodajTemperatureBezJednostki(cbMiasta.Text);
            lblTemperatura.Text = temp.ToString();

            if (temp < 0)
                pcObrazek.Image = Resources.snow;
            else if (temp < 10)
                pcObrazek.Image = Resources.cloud;
            else
                pcObrazek.Image = Resources.sun;
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            PodajTemerature();
        }

        private void cbMiasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            PodajTemerature();
        }
    }
}
