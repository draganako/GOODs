using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Probaaaa.DomainModel;

namespace Probaaaa
{
    public partial class kolekcijaDesc : Form
    {
        Kolekcija kol;

        public kolekcijaDesc()
        {
            InitializeComponent();
        }

        public kolekcijaDesc(ref Kolekcija k)
        {
            InitializeComponent();
            kol = k;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kol.opis = rtbDesc.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
