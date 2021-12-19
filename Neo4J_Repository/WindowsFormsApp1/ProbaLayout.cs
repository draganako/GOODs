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
    public partial class ProbaLayout : UserControl
    {
        private string text1, text2, text3;


        public ProbaLayout()
        {
            InitializeComponent();
        }

        private void btnProba_Click(object sender, EventArgs e)
        {
            tbxProba1.Text = "Neki tekst normal proba";
            tbxProba2.Text = "Neki drugi tekst normal proba";
            tbxProba3.Text = "Neki treci tekst normal proba";
        }

        private void tbxProba2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxProba3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxProba1_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetTexts(string txt1, string txt2, string txt3)
        {
            text1 = txt1;
            text2 = txt2;
            text3 = txt3;

            tbxProba1.Text = text1;
            tbxProba2.Text = text2;
            tbxProba3.Text = text3;
        }
    }
}
