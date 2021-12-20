using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19ZadanieNapisy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj zdanie");
            string zdanie = Console.ReadLine();

            string[] wyrazy = zdanie.Split(' ');

            int najdluzszy = wyrazy[0].Length;
            int indeksNajdluzszego = 0;

            for (int i = 1; i < wyrazy.Length; i++)
            {
                if (wyrazy[i].Length > najdluzszy)
                {
                    najdluzszy = wyrazy[i].Length;
                    indeksNajdluzszego = i;
                }
            }

            string najdluzszyWytaz = wyrazy[indeksNajdluzszego];
            Console.WriteLine(najdluzszyWytaz);

            Console.ReadKey();
        }
    }
}
