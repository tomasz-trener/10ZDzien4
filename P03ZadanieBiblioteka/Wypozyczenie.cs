using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    class Wypozyczenie
    {
        public string Czytelnik;
        public DateTime DataWypozyczenia;
        public DateTime DataPrzewidywanegoZwrotu;
        public DateTime DatazRzeczywistegoZwrotu;
        public string Uwagi;
        public Wypozyczenie Przedluzenie;
        public int NaliczonaKarta;
        public int ZaplaconaKarta;
    }
}
