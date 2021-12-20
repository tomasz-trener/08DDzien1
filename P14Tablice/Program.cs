using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie1 = "Adam";
            string imie2 = "Ala";
            string imie3 = "Jan";

            // tablice 

            string[] tablicaStringow = new string[3];

            tablicaStringow[0] = "Adam";
            tablicaStringow[1] = imie2;

            int[] tablicaIntow = new int[3];


            //pytanie co siedzi w tablicaStringow[2]

            for (int i = 0; i < tablicaStringow.Length; i++)
            {
                Console.WriteLine(tablicaStringow[i]);
            }

            bool[] tablicaWartosciLogicznch = new bool[2];
            tablicaWartosciLogicznch[0] = false;
            tablicaWartosciLogicznch[1] = true;

            char[] tablicaZnakow;



            Console.ReadKey();

        }
    }
}
