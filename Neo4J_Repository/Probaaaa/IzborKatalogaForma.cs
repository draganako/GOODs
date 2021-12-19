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
    public partial class IzborKatalogaForma : Form
    {
        Katalog kat;
        public IzborKatalogaForma()
        {
            InitializeComponent();
             kat = new Katalog();
            kat.kolekcije = new List<Kolekcija>();
            kat.proizvodi = new List<Proizvod>();

            
        }

        private void IzborKatalogaForma_Load(object sender, EventArgs e)
        {
            //dgKolekcije.Columns.Add("naziv", "ime");
            
            popuniListu();
            popuniListu2();
        }

        private void popuniListu()
        {
            
            dgKolekcije.DataSource = null;
            dgKolekcije.DataSource = kat.kolekcije;

        }


        private void popuniListu2()
        {
            
            dgProizvodi.DataSource = null;
            dgProizvodi.DataSource = kat.proizvodi;

        }

        private void btnNewCollection_Click(object sender, EventArgs e)
        {
            CatalogCollectionsAdminForm f = new CatalogCollectionsAdminForm(this);
            f.ShowDialog();

            popuniListu();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ProizvodiAdminForm f = new ProizvodiAdminForm(this);
            f.ShowDialog();

            popuniListu2();
        }

        public void addKoleckije(Kolekcija kk)
        {
            kat.kolekcije.Add(kk);
        }

        public void addProizvod(Proizvod kk)
        {
            kat.proizvodi.Add(kk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Proizvod p1 = Neo4JData.GetProizvodFromId("1");
            // Proizvod p2 = Neo4JData.GetProizvodFromId("2");

            //Kolekcija k = Neo4JData.GetKolekcijaFromId("6");
            DialogResult dr = MessageBox.Show("Are you sure you want to add this catalog?" +
                                                    " Once you do, you cannot make changes.");
            if (dr.Equals(DialogResult.OK))
            {
                if (!validateFields())
                {
                    MessageBox.Show("All of the fields have to be filled in!");
                    return;
                }
                if (kat.kolekcije.Count == 0 && kat.proizvodi.Count == 0)
                {
                    MessageBox.Show("Catalog must not be empty!");
                    return;
                }
               
                    kat.hashtag = tbxSeason.Text;
                    kat.year = Convert.ToInt32(tbxYear.Text);
                    kat.month = Convert.ToInt32(tbxMonth.Text);
                    // kat.proizvodi.Add(p1);
                    //kat.proizvodi.Add(p2);


                    //kat.kolekcije.Add(k);

                    Neo4JData.AddKatalog(kat);

                    MessageBox.Show("Catalog successfully created.");

                    this.Close();
                
            }
        }

        private bool validateFields()
        {
            if (tbxMonth.Text.Equals("") || tbxYear.Text.Equals("") || tbxSeason.Text.Equals(""))
                return false;
            else
                return true;
        }


    }
}
