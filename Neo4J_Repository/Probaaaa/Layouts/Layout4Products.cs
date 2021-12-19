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

namespace Probaaaa.Layouts
{
    public partial class Layout4Products : UserControl
    {
        Proizvod proizvod1, proizvod2, proizvod3, proizvod4;
        Image zvezdica;

        private void Layout4Products_Load(object sender, EventArgs e)
        {
            pbxZvezdica1.Visible = false;
            pbxZvezdica2.Visible = false;
            pbxZvezdica3.Visible = false;
            pbxZvezdica4.Visible = false;
            pbxZvezdica1.BackColor = Color.Transparent;
            pbxZvezdica2.BackColor = Color.Transparent;
            pbxZvezdica3.BackColor = Color.Transparent;
            pbxZvezdica4.BackColor = Color.Transparent;

           // zvezdica = Image.FromFile("product_img\\star.jpg");
        }

        public Layout4Products()
        {
            InitializeComponent();
        }

        private void LoadPictures(List<Proizvod> pro4)
        {
            foreach (Proizvod pr in pro4)
            {
                Image img = Image.FromFile("product_img\\" + pr.id + ".jpg");
                ChoosePbxImage(pr.id).Image = img;
            }
        }

        public void LoadProizvodi(List<Proizvod> proizvodi)
        {
            foreach (Proizvod p in proizvodi)
            {
                if (p.rating >= 4)
                {
                    ChoosePbxZvezdica(p.id).Image = zvezdica;
                    ChoosePbxZvezdica(p.id).Visible = true;
                }
            }
            
            LoadPictures(proizvodi);
        }

        private PictureBox ChoosePbxImage(String id)
        {
            switch (id)
            {
                case ("1"): return pbxImage1;
                case ("2"): return pbxImage2;
                case ("3"): return pbxImage3;
                default: return pbxImage4;
            }
        }

        private PictureBox ChoosePbxZvezdica(String id)
        {
            switch (id)
            {
                case ("1"): return pbxZvezdica1;
                case ("2"): return pbxZvezdica2;
                case ("3"): return pbxZvezdica3;
                default: return pbxZvezdica4;
            }
        }
    }
}
