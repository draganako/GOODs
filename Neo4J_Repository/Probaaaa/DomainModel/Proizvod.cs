using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probaaaa.DomainModel
{
    public class Proizvod
    {
        public String id { get; set; }
        public String name { get; set; }
        public String type { get; set; }
        public double cost { get; set; }
        public String proizvodjac { get; set; }
        public string opis { get; set; }
        public double rating { get; set; }
        public int wishes { get; set; }
        public String img { get; set; } ///////////samo cemo ovo da koristimo za sliku

        public List<Katalog> katalozi { get; set; } //katalozi u kojima je bio ovaj proizvod

        public override string ToString() /////////dopuniti
        {
            return String.Format("Naziv proizvoda: {0}, Tip: {1}, Cena: {2}", 
                                    name, type, cost.ToString());

        }
    }
}
