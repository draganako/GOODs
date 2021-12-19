using Neo4jClient;
using Neo4jClient.Cypher;
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
    public partial class KolekcijaForma : Form
    {
        CatalogCollectionsAdminForm parent;

        int layoutNo;
        int trenIndULay;

        List<Proizvod> proizvodiSvi;
        List<Proizvod> proizvodiSviRemovedOnes;//oni trenutno uklonjeni zbog searcha
        Proizvod trenutniSel;

        Kolekcija k;
       

        public KolekcijaForma(CatalogCollectionsAdminForm par)
        {
            parent = par;

            trenIndULay = 1;
            k = new Kolekcija();

            trenutniSel = null;
            InitializeComponent();

            proizvodiSvi = new List<Proizvod>();
            proizvodiSviRemovedOnes = new List<Proizvod>();
            k.proizvodi = new List<Proizvod>(3); //3 bira od svih
            k.proizvodi.Add(new Proizvod());
            k.proizvodi.Add(new Proizvod());
            k.proizvodi.Add(new Proizvod());

            proizvodLayout.Visible = false;
            lbxProizvodi.SelectedIndex = -1;

        }

        private void KatalogForma_Load(object sender, EventArgs e)
        {
            //ucitamo moguce teme kao picture box i radio button pa na koji klikne
            // to se prikazuje u jednom groupBoxu, kad klikne na next prikazuje se drugi

            gbIzborProizvoda.Visible = false;
            gbLejouti.Visible = false;
            gbTeme.Visible = true;

            proizvodiSvi = Neo4JData.dobaviSveProizvode();
            lbxProizvodi.DataSource = proizvodiSvi;//u listbox se upisuje predefinisana tostring funkcija za svaki proizvod!!!

            k.naziv = tbxName.Text;
            k.opis = "";
        }



        private void GenerisiLayout(Kolekcija k)
        {
            if (k.layout == 1)
            {
                layoutNo = 1;
                layout1Small.Visible = true;
                layout2Small.Visible = false;
            }
            else if (k.layout == 2)
            {
                layoutNo = 2;
                layout2Small.Visible = true;
                layout1Small.Visible = false;
            }
            else
            {
                /////kad dodamo jos layout-a
            }
        }

        private void SelectNextLayoutElement()
        {
            trenIndULay++;
            if (trenIndULay == 4)
                trenIndULay = 1;

            switch (layoutNo)
            {
                case 1: layout1Small.SelectElement(trenIndULay);break;
                case 2: layout2Small.SelectElement(trenIndULay); break;
                default: break;
            }

        }

        private void SelectPrevLayoutElement()
        {
            trenIndULay--;
            if (trenIndULay == 0)
                trenIndULay = 3;

            switch (layoutNo)
            {
                case 1: layout1Small.SelectElement(trenIndULay); break;
                case 2: layout2Small.SelectElement(trenIndULay); break;
                default: break;
            }
        }


        int getTemaFromRadio()
        {
            if (rbTema1.Checked == true)
                return 1;
            else if (rbTema2.Checked == true)
                return 2;
            else return 0;
        }

        int getLayoutFromRadio()
        {
            if (rbxMix.Checked == true)
                return 2;
            else if (rbxVertical.Checked == true)
                return 1;
            else return 0;
        }


        private void button3_Click(object sender, EventArgs e)//desc.
        {
            kolekcijaDesc c= new kolekcijaDesc(ref k);
           // c.FormClosed += new FormClosedEventHandler(Form_Closed);
            c.Show();
            
        }

      
        private void btnPrevItem_Click(object sender, EventArgs e)
        {

            if (k.proizvodi[trenIndULay - 1].id == null)
                MessageBox.Show("You must choose a product for this position!");
            else
            {
                lbxProizvodi.SelectedIndex = -1;
                SelectPrevLayoutElement();
                if (k.proizvodi[trenIndULay - 1].id != null)
                {
                    proizvodLayout.Visible = true;
                    proizvodLayout.SetUp(k.proizvodi[trenIndULay - 1]);
                    trenutniSel = k.proizvodi[trenIndULay - 1];
                }
                else
                {
                    if (lbxProizvodi.SelectedIndex >= 0)
                        trenutniSel = (Proizvod)lbxProizvodi.SelectedItem;
                    else
                        proizvodLayout.Visible = false;


                    ////////treba dodati da se ne prikazuju vec izabrani?????????

                }
            }            

        }


        private bool popunjenKatalog()
        {
            foreach (Proizvod pr in k.proizvodi)
            {
                if (pr.id == null)
                    return false;
            }
            return true;
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            foreach (Proizvod p in proizvodiSvi)
            {
                if (p.name.Contains(tbxSearch.Text) == false)
                    proizvodiSviRemovedOnes.Add(p);
            }

            foreach (Proizvod pp in proizvodiSviRemovedOnes)
                proizvodiSvi.Remove(pp);

            lbxProizvodi.DataSource = null;
            lbxProizvodi.DataSource = proizvodiSvi;
         
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            proizvodiSvi.AddRange(proizvodiSviRemovedOnes);
            proizvodiSviRemovedOnes.Clear();
            lbxProizvodi.DataSource = null;
            lbxProizvodi.DataSource = proizvodiSvi;
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//samo nece da doda u parenta
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {

            if (btnNext.Text == "Finish")
            {
                if (tbxName.Text.Equals(""))
                    MessageBox.Show("Collection has to have a name!");
                else
                {
                    k.naziv = tbxName.Text;
                    parent.dodajKolekciju(k);

                    MessageBox.Show("Collection successfully added.");
                    this.Close();
                }
            }


            //sada treba da mu prikazemo layout-e,  na slican nacin kao gore
            if (trenIndULay == 1)
            {
                trenIndULay = 2;

                gbIzborProizvoda.Visible = false;
                gbLejouti.Visible = true;
                gbTeme.Visible = false;

                k.tema = getTemaFromRadio();
            }
            else if (trenIndULay == 2)
            {
                trenIndULay = 3;

                gbIzborProizvoda.Visible = true;
                gbLejouti.Visible = false;
                gbTeme.Visible = false;

                k.layout = getLayoutFromRadio();
                GenerisiLayout(k);

                trenIndULay = 0;
                SelectNextLayoutElement();
            }
            else if (trenIndULay == 3)
            {
                trenIndULay = 1;

                gbIzborProizvoda.Visible = false;
                gbLejouti.Visible = false;
                gbTeme.Visible = true;


            }



            //drugi put kad klikne da se prikazu dinamicki proizvodi
            //tako sto se prikaze slika, prikaze se opis i ocena/predlog i jedan radio button 
            //koji kad se selektuje tako se bira proizvod
        }

        private void btnNextItem_Click_1(object sender, EventArgs e)
        {
            if (k.proizvodi[trenIndULay - 1].id == null)
                MessageBox.Show("You must choose a product for this position!");
            else
            {
                lbxProizvodi.SelectedIndex = -1;
                SelectNextLayoutElement();
                if (k.proizvodi[trenIndULay - 1].id != null)
                {
                    proizvodLayout.Visible = true;
                    proizvodLayout.SetUp(k.proizvodi[trenIndULay - 1]);
                    trenutniSel = k.proizvodi[trenIndULay - 1];
                }
                else
                {
                    if (lbxProizvodi.SelectedIndex >= 0)
                        trenutniSel = (Proizvod)lbxProizvodi.SelectedItem;
                    else
                        proizvodLayout.Visible = false;

                    ////////treba dodati da se ne prikazuju vec izabrani, probala sa removed ones za search, isti princip,KAKO
                    //lbxProizvodi.Items.RemoveAt(lbxProizvodi.SelectedIndex); //da se samo u lbx skloni, a da ostane u listi svih proizvoda

                }
            }
        }

        private void lbxProizvodi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbxProizvodi.SelectedIndex >= 0)
            {
                trenutniSel = (Proizvod)lbxProizvodi.SelectedItem;
                proizvodLayout.SetUp(trenutniSel);
                proizvodLayout.Visible = true;
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            if (trenutniSel != null)
            {
                k.proizvodi[trenIndULay - 1] = trenutniSel;
                MessageBox.Show("Product added.");

                if (popunjenKatalog())
                    btnNext.Text = "Finish";
            }
            else
                MessageBox.Show("Product selection is arbitrary!");
        }
    }

}
