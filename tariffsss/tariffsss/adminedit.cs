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
    public partial class adminedit : MaterialSkin.Controls.MaterialForm
    {
        public adminedit()
        {
            InitializeComponent();
        }

        private void adminedit_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            abonents adAbonents = new abonents();
            adAbonents.Show();
        }
    }
}
