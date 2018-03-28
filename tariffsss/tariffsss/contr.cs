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
    public partial class contr : MaterialSkin.Controls.MaterialForm
    {
        public contr()
        {
            InitializeComponent();
        }

        static MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='tariffsplan';username=root;password=41Elaset");

        private void contr_Load(object sender, EventArgs e)
        {
            down();
        }

        public void down()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("slCont", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void adAbonentsBtn_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;user=root;database=tariffsplan;port=3306;password=41Elaset;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            MySqlCommand cmd = new MySqlCommand("call addCont(@abid, @tvid, @planid)", myConn);

            MySqlParameter MC = new MySqlParameter();
            MC = cmd.Parameters.Add("abid", MySqlDbType.VarChar, 45);
            MC.Direction = ParameterDirection.Input;
            MC.Value = Convert.ToString(materialSingleLineTextField2.Text);

            MySqlParameter QT = new MySqlParameter();
            QT = cmd.Parameters.Add("tvid", MySqlDbType.VarChar, 45);
            QT.Direction = ParameterDirection.Input;
            QT.Value = Convert.ToString(materialSingleLineTextField3.Text);

            MySqlParameter QC = new MySqlParameter();
            QC = cmd.Parameters.Add("planid", MySqlDbType.VarChar, 45);
            QC.Direction = ParameterDirection.Input;
            QC.Value = Convert.ToString(materialSingleLineTextField4.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные добавлены");

            myConn.Close();
            down();
        }
    }
}
