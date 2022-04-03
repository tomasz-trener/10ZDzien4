using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieKalkulator
{
    class KalkulatorRownan
    {
        public double WykonajOperacje(string rownanie)
        {
            int pozPlus = rownanie.IndexOf("+");
            int pozMinus = rownanie.IndexOf("-");
            int pozMnozenie = rownanie.IndexOf("*");
            int pozDzielenie = rownanie.IndexOf("/");

            double wynik;

            if (pozPlus > -1)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozPlus)) +
                    Convert.ToInt32(rownanie.Substring(pozPlus + 1));
            else if (pozMinus > -1)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozMinus)) -
                    Convert.ToInt32(rownanie.Substring(pozMinus + 1));
            else if (pozMnozenie > -1)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozMnozenie)) *
                    Convert.ToInt32(rownanie.Substring(pozMnozenie + 1));
            else if (pozDzielenie > -1)
                wynik = Convert.ToDouble(rownanie.Substring(0, pozDzielenie)) /
                    Convert.ToDouble(rownanie.Substring(pozDzielenie + 1));
            else
            {
                throw new Exception("Podles nieznane rownanie");
            }

            return wynik;

        }
    }
}
