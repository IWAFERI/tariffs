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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            addtv adTV = new addtv();
            adTV.Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            chan ch = new chan();
            ch.Show();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            block bk = new block();
            bk.Show();
        }
    }
}
