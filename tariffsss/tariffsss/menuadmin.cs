using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tariffsss
{
    public partial class menuadmin : MaterialSkin.Controls.MaterialForm
    {
        public menuadmin()
        {
            InitializeComponent();
        }

        private void menuadmin_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            adminedit adEdit = new adminedit();
            adEdit.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
