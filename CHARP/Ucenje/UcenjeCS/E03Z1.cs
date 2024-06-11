using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {
        public static void Izvedi()
        {
            int godine;
            Console.WriteLine("Unesi broj godina: ");
            godine = int.Parse(Console.ReadLine());

            Console.WriteLine(godine < 18 ? "Maloljetan si" : "punoljetan si");

        }
    }
}
