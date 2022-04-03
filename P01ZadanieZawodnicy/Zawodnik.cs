using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieZawodnicy
{
    class Zawodnik
    {
        public int Id;
        public int IdTrenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public string ImieNazwisko
        {
            get { return Imie + " " + Nazwisko; }
        }


        public string PrzedstawSie()
        {
            return $"Nazywam się {ImieNazwisko} i pochodzę z {Kraj}";
        }


    }
}
