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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                Korisnik temp = Neo4JData.GetKorisnikPoKorImenu(tbxUsername.Text);
                if (temp != null)
                    MessageBox.Show("Username has to be unique!");
                else
                {
                    Korisnik k = new Korisnik();
                    k.ime = tbxName.Text;
                    k.prezime = tbxSurname.Text;
                    k.password = tbxPass.Text;
                    k.korisnicko = tbxUsername.Text;

                    Neo4JData.AddKorisnik(k);
                    MessageBox.Show("User successfully created.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please fill in all of the obligatory fields!");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            tbxPass.Clear();
            tbxPass.PasswordChar = '\u2022';
        }

        private bool ValidateInput()
        {
            if (String.IsNullOrEmpty(tbxUsername.Text) || String.IsNullOrEmpty(tbxName.Text)
                || String.IsNullOrEmpty(tbxSurname.Text) || String.IsNullOrEmpty(tbxPass.Text))
                return false;
            else
                return true;
        }

    }
}
