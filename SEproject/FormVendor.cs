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
    public partial class FormVendor : Form
    {

        OleDbConnection con = new OleDbConnection();
        public FormVendor()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             this.Hide();
            FormVendorRecord f1 = new FormVendorRecord();
            f1.Show();
        }

        private void BU2Save_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Vendor values('" + vendorid.Text + " ', ' " + name.Text + " ',' " + address.Text + " ',' " + landmark.Text + " ',' " + city.Text + " ',' " + state.Text + " ',' " + zipcode.Text + " ',' " + phone.Text + " ',' " + email.Text + " ',' " + mobile_no.Text + " ',' " + fax_no.Text + " ',' " + notes.Text + " ')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("One record has been added");
            con.Close();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void BU3Update_Click(object sender, EventArgs e)
        {
           
        }

        private void BU4Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Vendor where VendorId ='"+vendorid.Text  + " '";
            cmd.ExecuteNonQuery();
            MessageBox.Show(" record deleted successfully");
            con.Close();
        }

        private void BU1New_Click(object sender, EventArgs e)
        {
            vendorid.Text = "";
            name.Text = "";
            address.Text = "";
            landmark.Text = "";
            city.Text = "";
            state.Text = "";
            zipcode.Text = "";
            phone.Text = "";
            email.Text = "";
            mobile_no.Text = "";
            fax_no.Text = "";
            notes.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            FormVendorRecord f1 = new FormVendorRecord();
            f1.Show();
        }
    }
}
