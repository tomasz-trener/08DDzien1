using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfrę");

            int liczba = Convert.ToInt32(Console.ReadLine());

            if(liczba==1)
                Console.WriteLine("jeden");
            else if(liczba==2)
                Console.WriteLine("dwa");
            else if(liczba ==3)
                Console.WriteLine("trzy");
            else if (liczba == 4)
                Console.WriteLine("cztery");
            else if (liczba == 5)
                Console.WriteLine("piec");
            else if (liczba == 6)
                Console.WriteLine("szesc");
            else
                Console.WriteLine("inna");


            //gdy zawsze lewa strona jest taka sama oraz zawsze jest to porównanie 
            //wtedy mozemy zastosowac konstrukjcę switch case

            switch (liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                case 4:
                    Console.WriteLine("cztrey");
                    break;
                case 5:
                    Console.WriteLine("piec");
                    break;
                case 6:
                    Console.WriteLine("szesc");
                    break;
                default:
                    Console.WriteLine("inna");
                    break;
            }
        }
    }
}
