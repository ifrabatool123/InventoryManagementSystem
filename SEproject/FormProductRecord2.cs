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
    public partial class FormProductRecord2 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormProductRecord2()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "select ProductName , Weight,  Category from Product";
            com.CommandText = query;
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["ProductName"].ToString());
                comboBox2.Items.Add(reader["Weight"].ToString());
                comboBox3.Items.Add(reader["Category"].ToString());

            }
            
           
            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Product ", con);
            DataSet d1 = new DataSet("Product");
            con.Open();
            adap.Fill(d1, "Product");
            dataGrid1.DataSource = d1;
            con.Close();
        }

        private void dataGrid2_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void FormProductRecord2_Load(object sender, EventArgs e)
        {

        }
    }
}
