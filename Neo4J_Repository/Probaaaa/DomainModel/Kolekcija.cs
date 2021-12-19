using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probaaaa.DomainModel
{
    public class Kolekcija
    {
        public String id { get; set; }
        public String naziv { get; set; }
        public String opis { get; set; }
        public int tema { get; set; }
        public int layout { get; set; }

        public List<Proizvod> proizvodi { get; set; }

        public override string ToString() /////////dopuniti
        {
            return String.Format("Kolekcija: naziv: {0}, tema: {1}, layout: {2}, opis: {3}",
                                    naziv, tema, layout, opis);

        }
    }
}
