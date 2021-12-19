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
    public partial class ProizvodiAdminForm : Form
    {
        List<Proizvod> proizvodi;
        IzborKatalogaForma parentt;

        public ProizvodiAdminForm(IzborKatalogaForma f)
        {
            InitializeComponent();
            proizvodi = new List<Proizvod>();
            proizvodi = Neo4JData.dobaviSveProizvode();
            this.parentt = f;
        }
        

        private void btnChoose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item succesfully added to catalog!");
            if (dgProizvodi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Only one row may be selected!");
                return;
            }
            Proizvod k = proizvodi.ElementAt(dgProizvodi.SelectedRows[0].Index);


            parentt.addProizvod(k);
            this.Close();
            //pozvati da se doda item u katalog u bazi
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Item succesfully added to catalog!");

            AddProizvod forma = new AddProizvod();
            forma.ShowDialog();

           
            proizvodi = Neo4JData.dobaviSveProizvode();
            popuniListu();
        }


        private void popuniListu()
        {


            dgProizvodi.DataSource = null;
            dgProizvodi.DataSource = proizvodi;

        }

        private void ProizvodiAdminForm_Load(object sender, EventArgs e)
        {
           // proizvodi = Neo4JData.dobaviSveKolekcije();
            popuniListu();

            

            lblKolekcija.Text = "Name: " + proizvodi[0].name + "\nProducer: " + proizvodi[0].proizvodjac
                + "\nRating:" + proizvodi[0].cost + "\nWishes: " + proizvodi[0].wishes+ "\nDescription:" + proizvodi[0].opis;

        }

        private void dgProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProizvodi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Only one row may be selected!");
                return;
            }
            Proizvod k = proizvodi.ElementAt(dgProizvodi.SelectedRows[0].Index);


            lblKolekcija.Text = "Name: " + k.name + "\nProducer: " + k.proizvodjac
                + "\nRating:" + k.cost + "\nWishes: " + k.wishes+ "\nDescription:" + k.opis;
        }

        

        
    }
}
