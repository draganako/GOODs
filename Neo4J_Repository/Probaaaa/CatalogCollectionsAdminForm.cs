using Probaaaa.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probaaaa
{
    public partial class CatalogCollectionsAdminForm : Form
    {
       // Katalog katalog;
        IzborKatalogaForma parentt;
        List<Kolekcija> kolekcije;

        public CatalogCollectionsAdminForm()
        {
            InitializeComponent();
        }


        public CatalogCollectionsAdminForm(IzborKatalogaForma a)
        {
            InitializeComponent();
            kolekcije = new List<Kolekcija>();
            kolekcije = Neo4JData.dobaviSveKolekcije();
            parentt = a;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {//prosledimo kolekcije, na koje dodaje novu
            KolekcijaForma f = new KolekcijaForma(this);
            f.Show();
            kolekcije = Neo4JData.dobaviSveKolekcije();

            popuniListu();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dgKolekcije.SelectedRows.Count != 1)
            {
                MessageBox.Show("Only one row may be selected!");
                return;
            }
            Kolekcija k = kolekcije.ElementAt(dgKolekcije.SelectedRows[0].Index);


            parentt.addKoleckije( k);
            this.Close();
        }

        private void CollectionAdminForm_Load(object sender, EventArgs e)
        {
            kolekcije = Neo4JData.dobaviSveKolekcije();
            popuniListu();

            lblKolekcija.Text = "Naziv: " + kolekcije[0].naziv + " \nLayout: " + kolekcije[0].layout 
                + "\ntema" + kolekcije[0].tema + "\nOpis:" + kolekcije[0].opis;

        }

        private void popuniListu()
        {
            dgKolekcije.DataSource = null;
            dgKolekcije.DataSource = kolekcije;
          
        }

        private void dgKolekcije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgKolekcije_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           // List<Katalog> types = (List<Katalog>)dgKolekcije.DataSource;
            if (dgKolekcije.SelectedRows.Count != 1)
            {
                MessageBox.Show("Only one row may be selected!");
                return;
            }
            Kolekcija k = kolekcije.ElementAt(dgKolekcije.SelectedRows[0].Index);


            lblKolekcija.Text = "Name: "+ k.naziv + "\n Layout: " + k.layout
                + "\ntheme" + k.tema + "\nDescription:" + k.opis;
        }

        public void dodajKolekciju(Kolekcija k)
        {
            kolekcije.Add(k);
            popuniListu();

        }
    }
}
