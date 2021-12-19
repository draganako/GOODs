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
    public partial class AddProizvod : Form
    {
        private Image slikaProizvoda;

        public AddProizvod()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
            {
                //odabran je fajl
                slikaProizvoda = Image.FromFile(ofdUcitajSliku.FileName); //////
                pbxPicture.Image = slikaProizvoda;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btnAddProizvod_Click(object sender, EventArgs e)
        {
            if (ValidateUnos())
            {
                Proizvod novi = this.createProizvod();
                Neo4JData.AddProizvod(novi);
                MessageBox.Show("Successfully added a product!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The fields are not filled in correctly!");
            }
        }

        private bool ValidateUnos()
        {
            return true;
        }

        private Proizvod createProizvod()
        {
            Proizvod toret = new Proizvod();
            toret.name = tbxName.Text;
            toret.type = tbxType.Text;
            toret.cost = Double.Parse(tbxPrice.Text); ////treba odraditi fool proof check pre ovoga
            toret.proizvodjac = tbxProducer.Text;
            toret.opis = tbxOpis.Text;
            toret.rating = 0; //kreira se novi koji jos nema rating
            toret.wishes = 0; //isto i wishes

            return toret;
        }
    }
}