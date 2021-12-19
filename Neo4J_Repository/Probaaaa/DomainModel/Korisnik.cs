using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probaaaa.DomainModel
{
    public class Korisnik
    {
        public String id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String korisnicko { get; set; }
        public String password { get; set; }

        public Korisnik() { }
        public Korisnik(String id, String ime, String prez, String korime, String pass)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prez;
            this.korisnicko = korime;
            this.password = pass;
        }
    }
}
