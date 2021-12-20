using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12PetlaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string wyraz = "samochód";

            int i = 0;
            do
            {
                Console.WriteLine(wyraz.Substring(i,1));
                i++;

            } while (i<wyraz.Length);

            Console.ReadKey();

        }
    }
}
