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
    public partial class ProizvodForma : Form
    {
        private int productRating=5;
        private Korisnik ulogovanKorisnik;
        private Proizvod p;
        private Rating r;

        public ProizvodForma()
        {
            InitializeComponent();
        }


        public ProizvodForma(Proizvod p)
        {
            InitializeComponent();
            this.p = p;
           // ulogovanKorisnik = k;

            //za probu:
            this.p = Neo4JData.GetProizvodFromId("2");
           // this.ulogovanKorisnik = Neo4JData.GetKorisnikFromId("4");
        }

        public ProizvodForma(Proizvod p, Korisnik k)
        {
            InitializeComponent();
            this.p = p;
            ulogovanKorisnik = k;

            //za probu:
            this.p = Neo4JData.GetProizvodFromId("2");
            this.ulogovanKorisnik = Neo4JData.GetKorisnikFromId("4");
        }

        //dodaje se u wishlist korisnika, sto znaci da je prozivod dobar za to doba
        //MessageBox.Show("Succesfully added to wishlist!");
        ////treba da se zapamti ocena korisnika i predlozi ako je visoka
        //MessageBox.Show("Thanks for rating this product!");

            //ovi nam ne trebaju:
        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    productRating = 1;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    productRating = 2;

        //}

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    productRating = 3;

        //}

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    productRating = 4;

        //}

        //private void radioButton5_CheckedChanged(object sender, EventArgs e)
        //{
        //    productRating = 5;

        //}

        private void ProizvodForma_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name: " + p.name;
            lblCena.Text = "Cost: " + p.cost.ToString(); /////formatirati double na 2 decimale
            lblOcena.Text = "Rating: " + p.rating.ToString();
            lblProizvodjac.Text = "Proizvodjac: " + p.proizvodjac;
            lblOcena.Text = "Tip: " + p.type;

            if (pbxPicture.Image != null)
                pbxPicture.Image.Dispose(); //ako je bila prethodna uklanjamo je
            pbxPicture.Image = Image.FromFile("product_img\\" + p.id + ".jpg");

            r = Neo4JData.GetProductRating(p.id, ulogovanKorisnik.id);
            if (r != null)
            {
                if (r.ocena != null)
                    SetOcena(Int32.Parse(r.ocena));
                if (r.wish != null)
                    cbxWish.Checked = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (r == null && (radioButton1.Checked || cbxWish.Checked)) //ne postoji prethodni rating, a setovano je nesto
            {
                r.ocena = GetOcena();
                r.wish = (cbxWish.Checked) ? "1" : null;
                r.korisnik = ulogovanKorisnik;
                r.proizvod = p;
                Neo4JData.AddRatingToProduct(r);
            }
            else if (r != null)
            {
                r.wish = (cbxWish.Checked) ? "1" : null;
                r.ocena = GetOcena();
                Neo4JData.UpdateProductRating(r);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetOcena()
        {
            if (radioButton5.Checked)
                return "5";
            else if (radioButton4.Checked)
                return "4";
            else if (radioButton3.Checked)
                return "3";
            else if (radioButton2.Checked)
                return "2";
            else if (radioButton1.Checked)
                return "1";
            else
                return null;
        }

        private void SetOcena(int ocena)
        {
            if (ocena != 0)
                radioButton1.Checked = true;
            if (ocena > 1)
                radioButton2.Checked = true;
            if (ocena > 2)
                radioButton3.Checked = true;
            if (ocena > 3)
                radioButton4.Checked = true;
            if (ocena > 4)
                radioButton5.Checked = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
            radioButton5.Checked = false;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
            radioButton5.Checked = true;
        }
    }
}
