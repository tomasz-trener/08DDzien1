using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WczytywanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dzień dobry, jak się nazywasz?");

            string napis = Console.ReadLine();

            napis += " ok";
            Console.WriteLine(napis);

            Console.WriteLine("Ile masz lat?");

            string wiek = Console.ReadLine();

            int wiekInt = Convert.ToInt32(wiek);

            wiekInt = wiekInt + 1;

          //  string wynik = Convert.ToString(wiekInt);

            Console.WriteLine(wiekInt);

            Console.ReadKey();
        }
    }
}
