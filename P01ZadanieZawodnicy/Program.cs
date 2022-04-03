using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            ManagerZawodnikow mz = new ManagerZawodnikow(sciezka,TypImportu.Zdalny);
            mz.WygenerujZawodnikow();

            Console.WriteLine("kraj\tśrednia");
            GrupaKraj[] gk = mz.PodajSredniWzrostDlaKazdegoKraju();
            foreach (var g in gk)
                Console.WriteLine(g.NazwaKraju + "\t" + g.SredniWzrost);

            string podsuwamie = string.Format("Podsumowanie: średni wzrost wynosi: {0}" +
                " a średnia waga wynosi {1}",
                mz.PodajSredniWzrost(), mz.PodajSredniWage());

            Console.WriteLine(podsuwamie);
            Console.ReadKey();
        }
    }
}
