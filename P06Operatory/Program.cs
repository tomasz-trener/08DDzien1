using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            a = a + 1;

            a++; // zwiększenie o 1

            a = a - 1;

            a--; // zmniejszenie o 1

            a = a + 5;

            a += 5; // zwiększ o 5
            a -= 5; // zmniejsz o 5

            a = a * 3;

            a *= 3; // przemnoz przez 3

            a = a / 3;

            a /= 3; // przedziel przez 3 

            bool c1 = a == 10;
            bool c2 = a < 5;
            bool c3 = a >= 5;

            bool c4 = a < 5 || a > 10;

            bool c5 = a > 5 && a < 10;

            bool c6 = (a < 5 || a > 10) && a % 2 == 0;

            bool c7 = a != 5;

            bool c8 = !(a == 5);



        }
    }
}
