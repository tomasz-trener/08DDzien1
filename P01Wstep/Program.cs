using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Wstep
{
    class Program
    {
        static void Main(string[] args)
        {
            string zmiennaTekstowa = "hej";

            string zmiennaTekstowa2 = "5" + "6"; // wynik 56

            int zmiennaLiczbowa = 5 + 6;

            bool zmiennaLogiczna = false; // prawda lub fałsz

            short wiek = 60;
            long duzaLiczba = 2000;

            char znak = 'g';

            /*
             dowolna treść
            wielio 
            linowa
            */

            string nowaZmienna;


            //...
           

            nowaZmienna = "ala";
            Console.WriteLine(nowaZmienna);
            nowaZmienna = nowaZmienna + " ma kota";

            Console.WriteLine(nowaZmienna);



            Console.ReadKey();



        }
    }
}
