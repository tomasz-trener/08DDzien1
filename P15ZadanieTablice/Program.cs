using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15ZadanieTablice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zacznij podawać imiona, zakończ pisząc 'koniec'");

            string[] imiona = new string[50];

            int i = 0;

            do
            {
                string wczytaneImie = Console.ReadLine();
                if (wczytaneImie != "koniec")
                {
                    imiona[i] = wczytaneImie;
                    i++;
                }
                else
                    break;


            } while (true);

            //for (int j = 0; j < i; j++)
            //    Console.WriteLine(string.Format("{0} ({1})",imiona[j],imiona[j].Length));

            foreach (var x in imiona)
                if(x != null)
                    Console.WriteLine(string.Format("{0} ({1})", x,x.Length));


            string s1 = "ala";
            var s2 = "ala";

            int k1 = 4;
            var k2 = 4;

            //s2 = 4; // to będzie bład

            int[] liczby = new int[3];
            liczby[0] = 1;
            liczby[1] = 2;
            liczby[2] = 3;
            foreach (var item in liczby)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();

           

        }
    }
}
