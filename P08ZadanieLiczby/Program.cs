using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj równanie matematyczne");
            string rownanie = Console.ReadLine();

            //wersja 1 

            // 2+4
            // 012

            int liczba1 = Convert.ToInt32(rownanie.Substring(0, 1));
            int liczba2 = Convert.ToInt32(rownanie.Substring(2));
            string znak = rownanie.Substring(1, 1);

            int? wynik;

            //if (znak == "+")
            //    wynik = liczba1 + liczba2;
            //else
            //{
            //    if (znak == "-")
            //        wynik = liczba1 - liczba1;
            //    else
            //    {
            //        if (znak == "*")
            //            wynik = liczba1 * liczba2;
            //        else
            //            wynik = liczba1 / liczba2;
            //    }
            //}

            if (znak == "+")
                wynik = liczba1 + liczba2;
            else if (znak == "-")
                wynik = liczba1 - liczba2;
            else if (znak == "*")
                wynik = liczba1 - liczba2;
            else if (znak == "/")
                wynik = liczba1 / liczba2;
            else
                wynik = null;

            if (wynik == null)
                Console.WriteLine("niepoperawny działanie");
            else
                Console.WriteLine(wynik);
           
            Console.ReadKey();

        }
    }
}
