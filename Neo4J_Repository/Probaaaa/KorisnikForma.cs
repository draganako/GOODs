using Probaaaa.DomainModel;
using Probaaaa.Layouts;
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
    public partial class KorisnikForma : Form
    {
        //List<Kolekcija> kolekcije;
        // List<Proizvod> proizvodi;
        Katalog katalog;
        //Korisnik korisnik;

        int currentKol;
        int currentProductPage = 0;
        int noOfProdPages;

        public KorisnikForma()
        {
            InitializeComponent();
            // kolekcije = new List<Kolekcija>();
           // korisnik = new Korisnik();//zasad!!
        }

        public KorisnikForma(Katalog k)
        {
            InitializeComponent();
            //kolekcije = new List<Kolekcija>();
            katalog = k;
           // korisnik = new Korisnik();

        }

        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KorisnikForma_Load(object sender, EventArgs e)
        {
            userControl2.Visible = false;
            layout4Products.Visible = false; ///inicijalno

            currentKol = 0;
            //currentProductPage = -1;
            gbPrikaz.Visible = true;

            katalog.kolekcije = Neo4JData.GetKolekcijeFromKatalog(katalog.id);
            katalog.proizvodi = Neo4JData.GetProizvodiFromKatalog(katalog.id);
            noOfProdPages = katalog.proizvodi.Count / 4;


            if (katalog.kolekcije != null)
            {
                if (katalog.kolekcije[currentKol].layout == 1)
                {
                    userControl1.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);
                    if (katalog.kolekcije[currentKol].tema == 1)
                    {
                        userControl1.BackColor = Color.Salmon;
                    }
                    else
                    {
                        userControl1.BackColor = Color.MediumAquamarine;
                    }
                }
                else if (katalog.kolekcije[currentKol].layout == 2)
                {
                    userControl2.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);

                    if (katalog.kolekcije[currentKol].tema == 1)
                    {
                        userControl2.BackColor = Color.Salmon;
                    }
                    else
                    {
                        userControl2.BackColor = Color.MediumAquamarine;
                    }
                }

                GenerisiLayout(katalog.kolekcije[currentKol].layout);
                lblImeKol.Text = "Collection " + katalog.kolekcije[currentKol].naziv;
            }

            

            

        }



        private void btnViewMore_Click(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma();//kol.proiz
            p.ShowDialog();
        }


        private void GenerisiLayout(int layout)
        {
            if (layout == 1)
            {
                userControl1.Visible = true;
                userControl2.Visible = false;
                layout4Products.Visible = false;
            }
            else if (layout == 2)
            {
                userControl2.Visible = true;
                userControl1.Visible = false;
                layout4Products.Visible = false;
            }
            else
            {
                /////kad dodamo jos layout-a........
                layout4Products.Visible = true;
                userControl1.Visible = false;
                userControl2.Visible = false;
                lblImeKol.Text = "";

            }
        }

        private void btnPrevKol_Click(object sender, EventArgs e)
        {

            //foreach (Kolekcija kol in katalog.kolekcije)
            //{
            //    kol.proizvodi = Neo4JData.GetProizvodiFromKolekcija(kol.id);

                //    GenerisiLayout(katalog.kolekcije[currentKol].layout);
                //    userControl2.LoadProizvodi(kol.proizvodi);
                //    ucitajListuProizvoda(katalog.proizvodi);

                //}
             if (currentProductPage != -1)
            {
                // currentProductPage = -1;

                formirajpo4();
                GenerisiLayout(-1);
                currentProductPage--;

                if (currentProductPage == -1)
                {
                    currentKol = katalog.kolekcije.Count - 1;
                }
            }
            else if(currentKol != -1)
            {
                if (katalog.kolekcije[currentKol].layout == 1)
                {
                    userControl1.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);
                    if (katalog.kolekcije[currentKol].tema == 1)
                    {
                        userControl1.BackColor = Color.Salmon;
                    }
                    else
                    {
                        userControl1.BackColor = Color.MediumAquamarine;
                    }
                }
                else if (katalog.kolekcije[currentKol].layout == 2)
                {
                    userControl2.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);

                    if (katalog.kolekcije[currentKol].tema == 1)
                    {
                        userControl2.BackColor = Color.Salmon;
                    }
                    else
                    {
                        userControl2.BackColor = Color.MediumAquamarine;
                    }
                }

                GenerisiLayout(katalog.kolekcije[currentKol].layout);
                lblImeKol.Text = "Collection " + katalog.kolekcije[currentKol].naziv;
                currentKol--;

                if (currentKol == -1)
                {
                    currentProductPage = katalog.proizvodi.Count - 1;
                }
            }
            
           


            //if (currentKol == katalog.kolekcije.Count - 1)
            //    currentKol = -1;
            //else
            //    currentKol--;

            //if (currentProductPage == katalog.proizvodi.Count - 1)
            //{
            //    currentProductPage = -1;
            //    currentKol = 0;
            //}
            //else
            //{

            //}

            //if (currentKol == -1)
            //{
            //    formirajpo4();
            //    currentProductPage--;

            //    if(currentProductPage == 0)
            //    {
            //        currentKol = 0;
            //    }
            //    GenerisiLayout(-1);
            //}
            //else
            //{
            //    if (katalog.kolekcije[currentKol].layout == 1)
            //        userControl1.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);
            //    else if (katalog.kolekcije[currentKol].layout == 2)
            //        userControl2.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);

            //    GenerisiLayout(katalog.kolekcije[currentKol].layout);
            //    lblImeKol.Text = "Collection " + katalog.kolekcije[currentKol].naziv;

            //}
        }

        private void btnNextKol_Click(object sender, EventArgs e)
        {
            //if (currentKol == 100)
            //{
            //    if ((noOfProdPages - 1) == currentProductPage)
            //        currentKol = 0;
            //    else
            //        currentProductPage++;
            //}
            if (currentKol != katalog.kolekcije.Count )
            {
                if (katalog.kolekcije[currentKol].layout == 1)
                {
                    userControl1.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);
                    if (katalog.kolekcije[currentKol].tema == 1)
                    {
                        userControl1.BackColor = Color.Salmon;
                    }
                    else
                    {
                        userControl1.BackColor = Color.MediumAquamarine;
                    }
                }
                else if (katalog.kolekcije[currentKol].layout == 2)
                {
                    userControl2.LoadProizvodi(katalog.kolekcije[currentKol].proizvodi);

                    if (katalog.kolekcije[currentKol].tema == 1)
                    {
                        userControl2.BackColor = Color.Salmon;
                    }
                    else
                    {
                        userControl2.BackColor = Color.MediumAquamarine;
                    }
                }

                GenerisiLayout(katalog.kolekcije[currentKol].layout);
                lblImeKol.Text = "Collection " + katalog.kolekcije[currentKol].naziv;
                currentKol++;

               if(currentKol == katalog.kolekcije.Count)
                {
                    currentProductPage = 0;
                }
                
            }
            else if (currentProductPage != katalog.proizvodi.Count )
            {
                //currentProductPage = -1;

                formirajpo4();
                GenerisiLayout(-1);
                currentProductPage++;

                if (currentProductPage == katalog.proizvodi.Count)
                {
                    currentKol = 0;
                }
            }





        }

        void ucitajListuProizvoda(List<Proizvod> pro)
        {
            int x = 20, y = 20;
            for (int i = 0; i < pro.Count; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    y += 230;
                    x = 20;
                }

                ProizvodUListi lej = new ProizvodUListi(pro[i]);
                lej.Location = new Point(x, y);
                lej.Parent = gbLista;

                gbLista.Controls.Add(lej);
                x += 150;
            }
        }

        private void formirajpo4()
        {
            List<Proizvod> za4 = new List<Proizvod>();

            int pom = currentProductPage * 4;
            for (int i = pom; i < katalog.proizvodi.Count && i < pom + 4 ; i++)
            {
                if (i < katalog.proizvodi.Count)
                    za4.Add(katalog.proizvodi[i]);
            }
            layout4Products.LoadProizvodi(za4);

            //if (katalog.proizvodi.Count / 4 == currentProductPage)
            //    btnNextKol.Visible = false;
            //else
            //    btnNextKol.Visible = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Kolekcija kol in katalog.kolekcije)
            {
                if (tbxSearch.Text.Equals(kol.naziv))
                {
                    currentKol = katalog.kolekcije.IndexOf(kol);
                    GenerisiLayout(katalog.kolekcije[currentKol].layout);
                    return;
                }

            }
            MessageBox.Show("A collection with the given name doesn't exist!");
        }
    }
}
