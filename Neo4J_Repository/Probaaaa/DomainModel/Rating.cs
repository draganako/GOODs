using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probaaaa.DomainModel
{
    public class Rating
    {
        public Proizvod proizvod { get; set; }
        public Korisnik korisnik { get; set; }
        public string ocena { get; set; }
        public string wish { get; set; }
    }
}
