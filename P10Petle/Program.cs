using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i<10)
            {
                if (i==5)
                {
                    //break;
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
