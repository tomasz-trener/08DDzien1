using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            for (int i = 10; i > 0; i-=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
