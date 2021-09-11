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
using System.IO;
namespace SEproject
{
    public partial class FormStock : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormStock()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStockDetail1 f1 = new FormStockDetail1();
            f1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductRecord f1 = new FormProductRecord();
            f1.Show();
        }

        private void B2Save_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Stock values('" + txtID.Text + " ', ' " + txtPcode.Text + " ',' " + txtPname.Text + " ',' " + txtCategory.Text + " ',' " + txtWeight.Text + " ',' " + textBox2.Text + " ',' " + textBox3.Text + " ',' " + textBox4.Text + " ')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("One record has been added");
            con.Close();
        }

        private void B4Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Stock where StockID ='" + txtID.Text + " '";
            cmd.ExecuteNonQuery();
            MessageBox.Show(" record deleted successfully");
            con.Close();
        }

        private void B1New_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPcode.Text = "";
            txtPname.Text = "";
            txtCategory.Text = "";
            txtWeight.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }

        private void B3Update_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormStockDetail1 f1 = new FormStockDetail1();
            f1.Show();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Stock ", con);
            DataSet d1 = new DataSet("Stock");
            con.Open();
            adap.Fill(d1, "Stock");
            dataGrid1.DataSource = d1;
            con.Close();
        }
    }
}
