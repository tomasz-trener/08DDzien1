using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieLiczby2
{
    class Program
    {
        static void Main(string[] args)
        {
            // wersja 2

            Console.WriteLine("Wczytaj równanie matematyczne");
            string rownanie = Console.ReadLine();

            //12*567
            //012345

            int dodawanie = rownanie.IndexOf('+');
            int odejmowanie = rownanie.IndexOf('-');
            int mnozenie= rownanie.IndexOf('*');
            int dzielenie = rownanie.IndexOf('/');

            int? wynik = null;

            if (dodawanie > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, dodawanie));
                int liczba2 = Convert.ToInt32(rownanie.Substring(dodawanie+1));
                wynik = liczba1 + liczba2;
            }
            else if(odejmowanie > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, odejmowanie));
                int liczba2 = Convert.ToInt32(rownanie.Substring(odejmowanie + 1));
                wynik = liczba1 - liczba2;
            }
            else if (mnozenie > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, mnozenie));
                int liczba2 = Convert.ToInt32(rownanie.Substring(mnozenie + 1));
                wynik = liczba1 * liczba2;
            }
            else if (dzielenie > -1)
            {
                int liczba1 = Convert.ToInt32(rownanie.Substring(0, dzielenie));
                int liczba2 = Convert.ToInt32(rownanie.Substring(dzielenie + 1));
                wynik = liczba1 / liczba2;
            }

            if(wynik== null)
                Console.WriteLine("niepoprawne działanie");
            else
                Console.WriteLine(wynik);

            Console.ReadKey();
        }
    }
}
