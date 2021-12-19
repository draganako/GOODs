using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Probaaaa.DomainModel;

namespace Probaaaa
{
    public partial class Pocetna : Form
    {
        Korisnik loggedUser;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.Equals("admin") && UserExists())
            {
                AdminOpcije a = new AdminOpcije();
                a.Show();
            }
            else if (UserExists())
            {
                FormKorisnikKatalozi a = new FormKorisnikKatalozi();
                a.Show();
            }
            else
            {
                MessageBox.Show("Wrong log-in credentials!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKorisnikKatalozi a = new FormKorisnikKatalozi();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminOpcije a = new AdminOpcije();
            a.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Proizvod p1 = new Proizvod();
            p1.name = "dodaaaaat";
            p1.proizvodjac = "proizvodjackolekcija1";
            p1.cost = 3000;
            p1.type = "neki type";
            p1.rating = 0; //pri dodavanju 0 oba
            p1.wishes = 0;
            p1.opis = "neki opis";
            p1.img = "10";
            
            Proizvod res = Neo4JData.AddProizvod(p1);

            MessageBox.Show(res.id);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register odb = new Register();
            odb.Show();
        }

        private bool UserExists()
        {
            loggedUser = Neo4JData.UserExists(tbxUsername.Text, tbxPass.Text);
            //loggedUser = DataProvider.UserExists("neki1234", "jasamNeki");
            if (loggedUser != null)
                return true;
            else
                return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Neo4JData.DeleteKorisnikPoUsernameu(tbxUsername.Text);
        }

        private void btnAddKolekcija_Click(object sender, EventArgs e)
        {
            Proizvod p1 = Neo4JData.GetProizvodFromId("6");
            Proizvod p2 = Neo4JData.GetProizvodFromId("7");
            Proizvod p3 = Neo4JData.GetProizvodFromId("4");

            Kolekcija k = new Kolekcija();
            k.naziv = "new year collection";
            k.opis = "shine bright this winter with these brand new products"; //:D
            k.layout = 1;
            k.tema = 5;
            k.proizvodi = new List<Proizvod>();

            k.proizvodi.Add(p1);
            k.proizvodi.Add(p2);
            k.proizvodi.Add(p3);

            Proizvod probni = new Proizvod();
            probni.name = "Probni bez id-ja";
            k.proizvodi.Add(probni);

            Kolekcija res = Neo4JData.AddKolekcija(k);

            foreach (Proizvod p in res.proizvodi)
                if(p!=null)
                     MessageBox.Show(p.id);
        }

        private void btnReturnCollection_Click(object sender, EventArgs e)
        {
            Kolekcija k = Neo4JData.GetKolekcijaFromId("7");
            if (k == null)
            {
                MessageBox.Show("nema kolekcije");
                return;
            }
            MessageBox.Show(k.ToString());
            foreach (Proizvod p in k.proizvodi)
                MessageBox.Show(p.ToString());
        }

        private void btnAddKatalog_Click(object sender, EventArgs e)
        {
            Proizvod p1 = Neo4JData.GetProizvodFromId("4");
            Proizvod p2 = Neo4JData.GetProizvodFromId("6");

            Kolekcija k = new Kolekcija();
            k.naziv = "nova kolekcija za katalog";
            k.opis = "";
            k.layout = 2;
            k.tema = 2;
            k.proizvodi = new List<Proizvod>();

            Proizvod pro1 = new Proizvod();
            pro1.name = "Proizvod za kolekciju";

            k.proizvodi.Add(pro1);

            Katalog kat = new Katalog();
            kat.year = 2019;
            kat.month = 12;
            kat.proizvodi = new List<Proizvod>();
            kat.proizvodi.Add(p1);
            kat.proizvodi.Add(p2);

            kat.kolekcije = new List<Kolekcija>();
            kat.kolekcije.Add(k);

            Katalog res = Neo4JData.AddKatalog(kat);

            foreach (Proizvod p in res.kolekcije[0].proizvodi)
                MessageBox.Show(p.name + " " + p.id);
        }

        private void btnReturnKatalog_Click(object sender, EventArgs e)
        {
            Katalog k = Neo4JData.GetKatalogFromId("3");

            MessageBox.Show(k.ToString());

            foreach (Kolekcija kk in k.kolekcije)
                MessageBox.Show(kk.ToString());
            foreach (Proizvod p in k.proizvodi)
                MessageBox.Show(p.ToString());
        }

        private void btnGetAllKatalogs_Click(object sender, EventArgs e)
        {
            List<Katalog> katalozi = Neo4JData.dobaviSveKataloge();

            foreach (Katalog k in katalozi)
                MessageBox.Show(k.ToString());
        }

        private void btnGenTestData_Click(object sender, EventArgs e)
        {
            Neo4JData.DeleteAllData();
            Neo4JData.InsertTestData();
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.korisnik = Neo4JData.GetKorisnikFromId("4"); 
            rating.proizvod = Neo4JData.GetProizvodFromId("5"); //majica


            //postavljena oba atributa:
            rating.ocena = "3"; 
            rating.wish = "1"; //1 kad zeli, da bi lakse brojali 
            Neo4JData.AddRatingToProduct(rating);


            //veza koja ima samo wish:
            rating.ocena = null; //null kad nema ocenu
            rating.wish = "1"; 
            Neo4JData.AddRatingToProduct(rating);


            //veza koja ima samo ocenu
            rating.ocena = "2"; 
            rating.wish = null; //null kad ne zeli proizvod
            Neo4JData.AddRatingToProduct(rating);


            //veza bez atributa:
            rating.ocena = null; 
            rating.wish = null;
            Neo4JData.AddRatingToProduct(rating);
        }

        private void btnGetRating_Click(object sender, EventArgs e)
        {
            //ovo kad se otvara forma za pregled detalja proizvoda
            //da bi se prikazalo sta je dotadasnja ocena korisnika i wish
            //pa da moze da update-uje

            Korisnik k = Neo4JData.GetKorisnikFromId("4");
            Proizvod p = Neo4JData.GetProizvodFromId("1");

            if (k != null || p != null)
            {
                Rating currentRating = Neo4JData.GetProductRating(p.id, k.id);
                MessageBox.Show("The user already graded the product with: " + currentRating.ocena);
            }
            else
            {
                MessageBox.Show("can't grade");
            }
        }

        private void btnUpdateRating_Click(object sender, EventArgs e)
        {
            //id-jevi proizvoda i korisnika ce biti poznati
            //ovo se zove kad se korisniku prikazuje forma za detalje proizvoda, i on unese neku izmenu
            //izmene se smestaju u rating i radi se update

            Rating currentRating = Neo4JData.GetProductRating("1", "4");
            currentRating.wish = null; //uklanja zelju
            Neo4JData.UpdateProductRating(currentRating); //ovde ce da obrise granu

            Rating currentRating2 = Neo4JData.GetProductRating("2", "4");
            currentRating2.wish = null;
            currentRating2.ocena = "4";
            Neo4JData.UpdateProductRating(currentRating2);

        }

        private void btnPrikaziProizvod_Click(object sender, EventArgs e)
        {
            ProizvodForma pf = new ProizvodForma(null, null); //tamo podesavam probne
            pf.Show();
        }

        
    }
}
