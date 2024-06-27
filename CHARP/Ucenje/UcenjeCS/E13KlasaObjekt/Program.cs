using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt
{
    public class Program
    {
        public static void Izvedi()
        {
            Osoba osoba = new Osoba();
            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";
            Console.WriteLine(osoba.ImePrezime());
            Osoba ravnatelj = new Osoba();
            osoba.Ime = "Eduard";
            osoba.Prezime = "Kuzma";

            var direktor = new Osoba { Prezime = "Kas" };
            Console.WriteLine(direktor.Prezime?.ToUpper());



        }

    }
}
