﻿using System;
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
using MaterialSkin.Controls;

namespace tariffsss
{
    public partial class addtv : MaterialSkin.Controls.MaterialForm
    {
        public addtv()
        {
            InitializeComponent();
        }

       

        static MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='tariffsplan';username=root;password=41Elaset");

        public void down()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("slPlan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void addtv_Load(object sender, EventArgs e)
        {
            down();
        }

        private void adAbonentsBtn_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;user=root;database=tariffsplan;port=3306;password=41Elaset;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            MySqlCommand cmd = new MySqlCommand("call adPlan(@pName, @cent)", myConn);

            MySqlParameter MC = new MySqlParameter();
            MC = cmd.Parameters.Add("pName", MySqlDbType.VarChar, 45);
            MC.Direction = ParameterDirection.Input;
            MC.Value = Convert.ToString(materialSingleLineTextField2.Text);

            MySqlParameter QT = new MySqlParameter();
            QT = cmd.Parameters.Add("cent", MySqlDbType.Int32);
            QT.Direction = ParameterDirection.Input;
            QT.Value = Convert.ToString(materialSingleLineTextField3.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные добавлены");

            myConn.Close();
            down();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;user=root;database=tariffsplan;port=3306;password=41Elaset;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            MySqlCommand cmd = new MySqlCommand("call delPlan(@id)", myConn);

            MySqlParameter MC = new MySqlParameter();
            MC = cmd.Parameters.Add("id", MySqlDbType.VarChar, 45);
            MC.Direction = ParameterDirection.Input;
            MC.Value = Convert.ToString(materialSingleLineTextField1.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные удалены");

            myConn.Close();
            down();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            string myConnection = "server=localhost;user=root;database=tariffsplan;port=3306;password=41Elaset;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            MySqlCommand cmd = new MySqlCommand("call updPlan(@id, @pName, @cent)", myConn);

            MySqlParameter MC = new MySqlParameter();
            MC = cmd.Parameters.Add("id", MySqlDbType.Int32);
            MC.Direction = ParameterDirection.Input;
            MC.Value = Convert.ToString(materialSingleLineTextField1.Text);

            MySqlParameter DC = new MySqlParameter();
            DC = cmd.Parameters.Add("pName", MySqlDbType.VarChar, 45);
            DC.Direction = ParameterDirection.Input;
            DC.Value = Convert.ToString(materialSingleLineTextField2.Text);

            MySqlParameter MU = new MySqlParameter();
            MU = cmd.Parameters.Add("cent", MySqlDbType.VarChar, 45);
            MU.Direction = ParameterDirection.Input;
            MU.Value = Convert.ToString(materialSingleLineTextField3.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные изменены");

            myConn.Close();
            down();
        }
    }
}
