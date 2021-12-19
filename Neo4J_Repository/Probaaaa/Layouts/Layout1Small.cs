using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probaaaa.Layouts
{
    public partial class Layout1Small : UserControl
    {

        public Layout1Small()
        {
            InitializeComponent();

            pbxPicture1.BackColor = Color.Gray;
            pbxPicture2.BackColor = Color.Gray;
            pbxPicture3.BackColor = Color.Gray;
        }

        public void SelectElement(int elementNo)
        {
            if (elementNo == 1)
            {
                pbxPicture1.BackColor = Color.Coral;
                pbxPicture2.BackColor = Color.Gray;
                pbxPicture3.BackColor = Color.Gray;
            }
            else if (elementNo == 2)
            {
                pbxPicture1.BackColor = Color.Gray;
                pbxPicture2.BackColor = Color.Coral;
                pbxPicture3.BackColor = Color.Gray;
            }
            else if (elementNo == 3)
            {
                pbxPicture1.BackColor = Color.Gray;
                pbxPicture2.BackColor = Color.Gray;
                pbxPicture3.BackColor = Color.Coral;
            }
        }
    }
}
