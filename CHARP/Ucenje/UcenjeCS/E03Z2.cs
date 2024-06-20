using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {
        public static void Izvedi()
        {

            int p1;
            int p2;
            Console.WriteLine("Unesi broj 1: ");
            p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj 2: ");
            p2 = int.Parse(Console.ReadLine());

            if (p1 == p2)
            {
                Console.WriteLine("Jednaki su");

            }

            else

            {
                if (p1 > p2)
                {
                    Console.WriteLine(p1);

                }
                else { Console.WriteLine(p1); }
            }
        }
    }
}
