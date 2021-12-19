using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Probaaaa.DomainModel;

namespace Probaaaa.Layouts
{
    public partial class ProizvodUListi : UserControl
    {
        Proizvod pro;
        public ProizvodUListi()
        {
            InitializeComponent();
        }

        public ProizvodUListi(Proizvod p)
        {
            InitializeComponent();
            pro = p;
            SetUp(p);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma(pro, null); ////////treba pamtiti ulogovanog korisnika i to prosledjivati formi!!
            p.Show();

        }


        public void SetUp(Proizvod p)
        {
            lblNaziv.Text = "Name: " + p.name; /////formatirati double na 2 decimale
            lblCena.Text = "Cost: " + p.cost.ToString();

            if (pbProizvod.Image != null)
                pbProizvod.Image.Dispose(); //ako je bila prethodna uklanjamo je
            pbProizvod.Image = Image.FromFile("product_img\\" + p.img.ToString() + ".jpg");
            
            //slika ce zapravo da se preuzima iz baze -- najbolje zasebnim upitom, da ne bi uvek ucitavali, vec samo kad zatreba
        }

        private void pbProizvod_Click(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma(pro, null); ////ulogovan korisnik treba da se prosledjuje ovde
            p.Show();
        }
    }
}
