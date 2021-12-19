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
using Probaaaa.Layouts;

namespace Probaaaa
{
    public partial class UserControl1 : UserControl
    {
        Proizvod proizvod1, proizvod2, proizvod3;

        public UserControl1()
        {
            InitializeComponent();

            proizvod1 = new Proizvod();
            proizvod2 = new Proizvod();
            proizvod3 = new Proizvod();
        }

        private void btnDetails1_Click(object sender, EventArgs e)
        {
            
           ProizvodForma p = new ProizvodForma(proizvod1);
           p.Show();
        }


        private void btnDetails1_Click_1(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma(proizvod1);
            p.Show();
        }

        private void btnDetails2_Click_1(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma(proizvod2);
            p.Show();
        }

        private void btnDetails3_Click_1(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma(proizvod3);
            p.Show();
        }

        private void LoadPictures(String id1, String id2, String id3)
        {
            Image img1 = Image.FromFile("product_img\\" + id1 + ".jpg");
            Image img2 = Image.FromFile("product_img\\" + id2 + ".jpg");
            Image img3 = Image.FromFile("product_img\\" + id3 + ".jpg");

            pbxPicture1.Image = img1;
            pbxPicture2.Image = img2;
            pbxPicture3.Image = img3;
        }

        public void LoadProizvodi(List<Proizvod> proizvodi)
        {
            proizvod1 = proizvodi[0];
            proizvod2 = proizvodi[1];
            proizvod3 = proizvodi[2];

            LoadPictures(proizvod1.img, proizvod2.img, proizvod3.img);
        }
    }
}
