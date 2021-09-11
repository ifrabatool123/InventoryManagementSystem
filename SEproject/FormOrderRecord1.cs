using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SEproject
{
    public partial class FormOrderRecord1 : Form
    {

        OleDbConnection con = new OleDbConnection();
        public FormOrderRecord1()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "select OrderNo from OrderInfo";
            com.CommandText = query;
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                comOrder.Items.Add(reader["OrderNo"].ToString());
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void FormOrderRecord1_Load(object sender, EventArgs e)
        {

        }

        private void comOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
