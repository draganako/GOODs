using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Layout1 : UserControl
    {

        public Layout1()
        {
            InitializeComponent();
        }

        public void LoadPictures(int id1, int id2, int id3)
        {
            ///////ovo ce morati preko baze nekako
            /////i mora da se ogranici velicina slike na picture box - zasad sam stavila sizemode na strech

            Image img1 = Image.FromFile("D:\\TINA\\VII semestar\\Napredne baze podataka\\Projekti\\Projekat 2 (Neo4J)\\Neo4J_Repository\\WindowsFormsApp1\\" + id1.ToString() + ".jpg");
            Image img2 = Image.FromFile("D:\\TINA\\VII semestar\\Napredne baze podataka\\Projekti\\Projekat 2 (Neo4J)\\Neo4J_Repository\\WindowsFormsApp1\\" + id2.ToString() + ".jpg");
            Image img3 = Image.FromFile("D:\\TINA\\VII semestar\\Napredne baze podataka\\Projekti\\Projekat 2 (Neo4J)\\Neo4J_Repository\\WindowsFormsApp1\\" + id3.ToString() + ".jpg");

            pbxPicture1.Image = img1;
            pbxPicture2.Image = img2;
            pbxPicture3.Image = img3;
        }

        private void btnDetails1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDetails2_Click(object sender, EventArgs e)
        {

        }

        private void btnDetails3_Click(object sender, EventArgs e)
        {

        }
    }
}
