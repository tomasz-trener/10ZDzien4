using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieBiblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta()
            {
                NrKarty = new int[2] { 1308, 0 },
                Tytul = "O kurdlach dla opornych",
                Wydanie = 1,
                Autor = new Autor[2]
                {
                  new Autor() { Imie="L", DrugieImie="A", Nazwisko="Tarantoga"},
                  new Autor() { Imie="I", Nazwisko="Tichy"},
                },
                Nastepne = new Karta()
                {
                    NrKarty = new int[2] { 2, 1 },
                    Tytul = "O kurdlach dla początkujących"
                },
                Sygnatury = new Sygnatura[1]
                {
                    new Sygnatura()
                    {
                        Cena = new Cena()
                        {
                            Wartosc=17.5,
                            Komentarz = "zakup z..."
                        },
                        Komentarz="zgłoszona utrata 01.05.2000",
                        StanAktywnosci= false,
                        NumerSygnatury= 012371,
                        DataZakupu = new DateTime(2000,1,27),
                        Wypozyczenia = new Wypozyczenie[1]
                        {
                            new Wypozyczenie()
                            {
                                Czytelnik ="B2354",
                                DataWypozyczenia = new DateTime(2000,2,22),
                                Uwagi = "06.03.2000 Zgoda na przedłużeni",
                                Przedluzenie =
                                    new Wypozyczenie()
                                    {
                                        DatazRzeczywistegoZwrotu = new DateTime(2000,3,15)
                                    }
                            }
                        }
                    }
                }

            };

            DateTime d =
            k.Sygnatury[0].Wypozyczenia[0].Przedluzenie.DatazRzeczywistegoZwrotu;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
