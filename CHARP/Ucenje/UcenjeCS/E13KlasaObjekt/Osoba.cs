using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt
{
    public class Osoba
    {

        public string? Ime { get; set; }

        public string? Prezime { get; set; }
        public int? Sifra   { get; set; }
        public string? ImePrezime()
        {
            return Ime + " " + Prezime;

        }
    }
}
