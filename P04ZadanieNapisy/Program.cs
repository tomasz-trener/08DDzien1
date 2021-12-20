using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int wynik = a + b;

            int dlugosc = Convert.ToString(wynik).Length;

            //   Console.WriteLine("wynik to: " + wynik);
            //    Console.WriteLine("długość to: " + dlugosc);

            // string tekst = "wynik to:" + Convert.ToString(wynik) + " a długośc napisu to: " + dlugosc;

            // string tekst = string.Format("wynik to {0} a długośc napisu to {1}", wynik, dlugosc);

            string tekst = $"wynik to {wynik} a długośc napisu to {dlugosc}";


            

            Console.WriteLine(tekst);

            Console.ReadKey();
        }
    }
}
