using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieFirma
{

    //2022/GKOP
    class Faktura
    {
        // pola, wlasciwosci, metody , konstruktory 


        public List<Towar> Towary = new List<Towar>();
        private int numer;
        private string nazwa;

        public string Tytul
        {
            get
            {
                return $"{numer}/{nazwa}";
            }
            set
            {
                string[] w = value.Split('/');
                numer = Convert.ToInt32(w[0]);
                nazwa = w[1].ToUpper();
            }
        }

        //public string PodajTytulFaktury()
        //{
        //    return $"{numer}/{nazwa}";
        //}

        //public void UstawTytulFaktury(string nazwa, int numer)
        //{
        //    this.nazwa = nazwa.ToUpper();
        //    this.numer = numer;
        //}


        public DateTime DataUtworzenia;
    }
}
