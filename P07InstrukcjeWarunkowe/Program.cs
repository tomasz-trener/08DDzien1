using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            bool c1= wzrost > 185;

            if (c1)
                Console.WriteLine("jesteś wyoski");
            else
                Console.WriteLine("jesteś niski");

            if (wzrost>185)
                Console.WriteLine("jesteś wysoki");
            else
                Console.WriteLine("jesteś niski");


            if (wzrost>185)
            {
                Console.WriteLine("jesteś wyoski");
                Console.WriteLine("Gratuacje!");
            }
            else
                Console.WriteLine("jesteś niski");
                
            
            Console.WriteLine("koniec");


            if (wzrost>185)
                if (wzrost>200)
                    Console.WriteLine("jesteś bardzo wyoski");
                else
                    Console.WriteLine("jesteś wysoki");      
            else
                Console.WriteLine("jesteś niski");


            string wynik;
            if (wzrost > 185)
            {
                wynik = "jesteś wysoki";
            }
            else
            {
                wynik = "jesteś niski";
            }
            Console.WriteLine(wynik);


            // skrótowy zapis if

            string wynik2 = wzrost > 185 ? "jesteś wyoski" : "jesteś niski";

            string wynik3 = wzrost > 185 ? "jesteś wyoski" : wzrost > 160 ? "jesteś średni" : "jesteś niski";


            Console.ReadKey();




        }
    }
}
