using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadaniePogoda
{
    class ManagerPogody
    {
        public string PodajTemperature(string nazwaMiasta)
        {
            const char znak = '°';
            const string znakKoncowy = ">";

            string adres = $"https://www.google.com/search?q=pogoda {nazwaMiasta}";
            string dane = new WebClient().DownloadString(adres);

            int indx = dane.IndexOf(znak);
            int aktualnaPoz = indx;

            while (dane.Substring(aktualnaPoz, 1) != znakKoncowy)
                aktualnaPoz--;

            string wynik = dane.Substring(aktualnaPoz + 1, indx + 1 - aktualnaPoz);
            return wynik;
        }

        public int PodajTemperatureBezJednostki(string nazwaMiasta)
        {
            string wynik = PodajTemperature(nazwaMiasta);
            return Convert.ToInt32(wynik.Substring(0, wynik.Length - 2));
        }
    }
}
