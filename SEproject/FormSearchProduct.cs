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
    public partial class FormSearchProduct : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormSearchProduct()
        {

            
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";

                 con.Open();
                 OleDbCommand com = new OleDbCommand();
                 com.Connection = con;
                 string query = "select ProductName from Product";
                 com.CommandText = query;
                 OleDbDataReader reader = com.ExecuteReader();
                 while (reader.Read())
                 {
                     comboBox1.Items.Add(reader["ProductName"].ToString());
                 }
                 con.Close();
             
        }
        private void FormSearchProduct_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string a = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT ProductCode, ProductName, Category, Weight, Price FROM Product WHERE Product = '"+comboBox1.SelectedItem +"' ", con);
            DataTable d1 = new DataTable("Product");
            adap.Fill(d1);
            dataGrid1.DataSource = d1;
           // OleDbConnection con = new OleDbConnection();
           /*OleDbCommand cmd = new OleDbCommand();
           cmd.CommandText="SELECT ProductCode, ProductName,Category,Weight,Price FROM Product WHERE Product='"+comboBox1.SelectedItem +"' ";

           cmd.Connection = con;


            DataSet d1 = new DataSet("Product");
            OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
            adap.Fill(d1);
            dataGrid1.DataSource = d1.Tables[0];*/

        }
    }
}
