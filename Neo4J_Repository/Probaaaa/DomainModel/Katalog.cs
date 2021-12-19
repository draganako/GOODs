using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probaaaa.DomainModel
{
    public class Katalog
    {
        public String id { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public String hashtag { get; set; }

        public List<Proizvod> proizvodi { get; set; }
        public List<Kolekcija> kolekcije { get; set; }

        public override string ToString()
        {
            return String.Format("Katalog: year = {0}, month = {1}, hashtag = {2}", year, month, hashtag);
        }

    }
}
