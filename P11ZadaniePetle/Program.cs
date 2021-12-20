using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadaniePetle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj zdanie");
            string zdanie = Console.ReadLine();

            Console.WriteLine("Wczytaj wyraz");
            string wyraz = Console.ReadLine();

            //ala ma kota                           //ala ma kota i ma psa
            //012345678910                          //              ma 

            int i = 0;
            int suma = 0;
            while (i<zdanie.Length-wyraz.Length+1)
            {
                string podciag = zdanie.Substring(i, wyraz.Length);
                if (podciag == wyraz)
                    suma++;

                i++;
            }

            // 30-60 min 
            // 45  

            // 13:10

            Console.WriteLine(suma);
            Console.ReadKey();

        }
    }
}
