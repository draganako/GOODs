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
    public partial class AdminOpcije : Form
    {
        List<Katalog> katalozi;
        public AdminOpcije()
        {
            InitializeComponent();
            katalozi = new List<Katalog>();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to finish?");
            if(dr.Equals(DialogResult.OK))
                this.Close();
        }

       
        private void AdminOpcije_Load(object sender, EventArgs e)
        {
            lbKatalozi.Items.Clear();

            katalozi = Neo4JData.dobaviSveKataloge();
            katalozi.ForEach(a => lbKatalozi.Items.Add(a));
            lbKatalozi.SelectionMode = SelectionMode.None;

        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzborKatalogaForma f = new IzborKatalogaForma();

            f.ShowDialog();

            lbKatalozi.Items.Clear();
            katalozi = Neo4JData.dobaviSveKataloge();
            katalozi.ForEach(a => lbKatalozi.Items.Add(a));
        }
    }
}
