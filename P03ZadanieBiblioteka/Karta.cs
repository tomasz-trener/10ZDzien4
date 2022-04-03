using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    class Karta
    {
        public string Tytul;
        public int[] NrKarty;
        public int Wydanie;
        public Karta Nastepne;
        public Karta Poprzednie;
        public Sygnatura[] Sygnatury;
        public Autor[] Autor;
    }
}
