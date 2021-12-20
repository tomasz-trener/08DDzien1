using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17TabliceIStringi
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala*!ma*!*!kota*!";
            string[] separatory = { "*!" };
            string[] tablica =napis.Split(separatory, StringSplitOptions.RemoveEmptyEntries);
           // string[] tablica = napis.Split(';');

            foreach (var x in tablica)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();

        }
    }
}
