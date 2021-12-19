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
    public partial class FormKorisnikKatalozi : Form
    {
        public FormKorisnikKatalozi()
        {
            InitializeComponent();
        }

        private void btnPogledajKolekciju_Click(object sender, EventArgs e)
        {
            List<Katalog> types = (List<Katalog>)dgvDisp.DataSource;
            if (dgvDisp.SelectedRows.Count != 1)
            {
                MessageBox.Show("Only one row may be selected!");
                return;
            }
            Katalog selectedType = types.ElementAt(dgvDisp.SelectedRows[0].Index);
           
            KorisnikForma kf = new KorisnikForma(selectedType);
            kf.Show();

        }

        private void dgvDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKorisnikKatalozi_Load(object sender, EventArgs e)
        {
            dgvDisp.DataSource = Neo4JData.dobaviSveKataloge();

            dgvDisp.Columns[0].HeaderText = "ID";
            dgvDisp.Columns[1].HeaderText = "hashtag";
            dgvDisp.Columns[2].HeaderText = "month";
            dgvDisp.Columns[3].HeaderText = "year";
        }
    }
}
