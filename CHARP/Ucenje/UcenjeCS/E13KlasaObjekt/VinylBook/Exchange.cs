using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.VinylBook
{
    internal class Exchange
    {
        public int Id { get; set; }
        public User Participant { get; set; }
        public int? Exchange_id { get; set; }
        public Album Album { get; set; }
        public Record_copie? Record_copie_id { get; set; }
        public string Estatus { get; set; }

    }
}
