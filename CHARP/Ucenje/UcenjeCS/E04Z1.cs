using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            int ocjena;
            Console.WriteLine("Unesi ocjenu: ");
            ocjena = int.Parse(Console.ReadLine());

            switch(ocjena)
            { 
                case 1:
                Console.WriteLine("Nedovoljan");
                break;
            case 2:
                Console.WriteLine("Dovoljan");
                break;
            case 3:
                Console.WriteLine("Dobar");
                break;
            case 4:
                Console.WriteLine("Vrlodobar");
                break;
            case 5:
                Console.WriteLine("odlican");
                break;
            default:
                Console.WriteLine("Neije ocjena");
                break;



            }
    }
}
}
