using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    class Sygnatura
    {
        public Cena Cena;
        public DateTime DataZakupu;
        public string Komentarz;
        public int NumerSygnatury;
        public bool StanAktywnosci;
        public Wypozyczenie[] Wypozyczenia;
    }
}
