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
    public partial class ProizvodLayout : UserControl
    {
        public ProizvodLayout()
        {
            InitializeComponent();
        }

        public void SetUp(Proizvod p)
        {
            lblName.Text = "Name: " + p.name;
            lblCena.Text = "Cost: " + p.cost.ToString(); /////formatirati double na 2 decimale
            lblOcena.Text = "Rating: " + p.rating.ToString();
            lblProizvodjac.Text = "Producer: " + p.proizvodjac;
            lblOcena.Text = "Type: " + p.type;

            if (pbxPicture.Image != null)
                pbxPicture.Image.Dispose(); //ako je bila prethodna uklanjamo je
            pbxPicture.Image = Image.FromFile("product_img\\" + p.img.ToString() + ".jpg");
            //slika ce zapravo da se preuzima iz baze -- najbolje zasebnim upitom, da ne bi uvek ucitavali, vec samo kad zatreba
        }

        private void ProizvodLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
