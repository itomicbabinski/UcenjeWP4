using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Z1
    {

        public static void Izvedi()
        {
            int[] godine = new int[12];
            godine[0] = 11;
            godine[1] = 12;
            godine[2] = 13;
            godine[3] = 14;
            godine[4] = 15;
            godine[5] = 16;
            godine[6] = 17;
            godine[7] = 18;
            godine[8] = 19;
            godine[9] = 20;
            godine[10] = 21;
            godine[11] = 22;
            

            Console.WriteLine(godine);
            Console.WriteLine(string.Join(",", godine));

        }

        }
    }
