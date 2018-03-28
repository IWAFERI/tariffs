using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace tariffsss
{
    public partial class check : MaterialSkin.Controls.MaterialForm
    {
        public check()
        {
            InitializeComponent();
        }

        static MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='tariffsplan';username=root;password=41Elaset");

        private void check_Load(object sender, EventArgs e)
        {
            down();
        }

        public void down()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("slAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}
