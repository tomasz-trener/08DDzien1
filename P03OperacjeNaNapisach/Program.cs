using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03OperacjeNaNapisach
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";

            int dlugosc = s.Length;

            Console.WriteLine(dlugosc);

            string w1 =  s.Substring(4); // ma kota
            string w2 = s.Substring(4, 2); // ma

            string w3 = s.Replace("ma", "będzie miała"); // ala będzie miała kota

            Console.WriteLine(w3);

            bool czyZawiera= s.Contains("ma"); // true

            string w4 = s.ToUpper(); // ALA MA KOTA
            string w5 =  s.ToLower(); // zamiana na małe litery

            int indeksPozycji = s.IndexOf("ma"); //4 



            Console.ReadKey();
        }
    }
}
