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

namespace Probaaaa
{
    public partial class UserControl2 : UserControl
    {
        Proizvod proizvod1, proizvod2, proizvod3;

        public UserControl2()
        {
            InitializeComponent();

            proizvod1 = new Proizvod();
            proizvod2 = new Proizvod();
            proizvod3 = new Proizvod();
        }


        private void pbxPicture2_Click(object sender, EventArgs e)//first
        {
            ProizvodForma p = new ProizvodForma(proizvod1, null); //svuda treba pamtiti i korisnika!!
            p.Show();
        }

        private void pbxPicture1_Click(object sender, EventArgs e)
        {
            ProizvodForma p = new ProizvodForma(proizvod1, null);
            p.Show();
        }

        private void pbxPicture2_Click_1(object sender, EventArgs e)//second
        {
            ProizvodForma p = new ProizvodForma(proizvod2, null);
            p.Show();
        }

        private void pbxPicture3_Click(object sender, EventArgs e)//third
        {
            ProizvodForma p = new ProizvodForma(proizvod3, null);
            p.Show();
        }

        private void pbxPicture1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGray;

        }

        private void pbxPicture1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = UserControl2.DefaultBackColor;

        }

        private void pbxPicture2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.BlueViolet;

        }

        private void pbxPicture2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = UserControl2.DefaultBackColor;

        }

        private void pbxPicture3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.BlueViolet;

        }

        private void pbxPicture3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = UserControl2.DefaultBackColor;

        }

        private void LoadPictures(String id1, String id2, String id3)
        {
            ///////ovo ce morati preko baze nekako
            /////i mora da se ogranici velicina slike na picture box - zasad sam stavila sizemode na strech

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
