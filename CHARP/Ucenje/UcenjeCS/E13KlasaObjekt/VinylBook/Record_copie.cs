using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.VinylBook
{
    internal class Record_copie
    {
       public int Id { get; set; }
       public Album Album { get; set; }
       public User Owner { get; set; }
       public String? Media_condition { get; set; }
        public String? Sleve_condition { get; set; }
        public String? Sound_condition { get; set; }
        public Boolean Duplicate { get; set; }
        public String? Comment_private { get; set; }
        public String? Comment_public { get; set; }





    }
}
