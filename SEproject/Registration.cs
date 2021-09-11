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
    public partial class Registration : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Registration()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {


            Registration_Detail f1 = new Registration_Detail();
            f1.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)

            {
                con.Close();
            }
            con.Open();
           /* OleDbDataAdapter adap = new OleDbDataAdapter("select * from Registration ", con);
            DataSet d1 = new DataSet("Registration");
            textBox1.Text = d1.Tables[0].Rows[0]["Username"].ToString();
            password.Text = d1.Tables[0].Rows[0]["Password"].ToString();
            name.Text = d1.Tables[0].Rows[0]["Name"].ToString();
            contact_no.Text = d1.Tables[0].Rows[0]["ContactNo"].ToString();*/
        }

        private void BUT1New_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            password.Text = "";
            name.Text = "";
            contact_no.Text = "";
           
        }

        private void contact_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUT2Save_Click(object sender, EventArgs e)
        {
            try{ con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Registration values('" + textBox1.Text + " ', ' " + password.Text + " ',' " + name.Text + " ',' " + contact_no.Text + " ')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("One record has been added");
            con.Close(); }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }

        }

        private void BUT3Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand com1 = con.CreateCommand();
                com1.CommandType = CommandType.Text;
                com1.CommandText = "update Registration set  Username='" + textBox1.Text + "'Password='" + password.Text + "'Name='" + name.Text + "'ContactNo='" + contact_no.Text + "' where Username= '" + textBox1.Text + "'";
               
                com1.ExecuteNonQuery();
                MessageBox.Show("One record has been updated ");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
        }

        private void BUT4Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                string query = "delete from Registration where Username =  '" + textBox1.Text + " '";
                com1.CommandText = query;
                com1.ExecuteNonQuery();
                MessageBox.Show("One record has been deleted ");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
        }
    }
}
