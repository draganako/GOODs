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
    public partial class ProbaLayoutSmall : UserControl
    {
        public ProbaLayoutSmall()
        {
            InitializeComponent();
        }

        private void btnProba_Click(object sender, EventArgs e)
        {
            tbxProba1.Text = "Neki tekst";
            tbxProba2.Text = "Neki drugi tekst";
            tbxProba3.Text = "Neki treci tekst";
        }
    }
}
