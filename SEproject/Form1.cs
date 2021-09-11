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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            

            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            com1.CommandText = "select * from Users where Username='" + name.Text + "' and Password='" + password.Text + "'";
            OleDbDataReader reader = com1.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {

                count = count + 1;

            }
            if (count == 1)
            {
                this.Hide();
                Main f1 = new Main();
                f1.Show();
            }
            else if (count >1)
            {
                MessageBox.Show(" duplicate Username and password ");
            }
            else
            {
                MessageBox.Show("Username and password is incorrect");
            }
            con.Close();
            /*if (name.Text == "")
            {
                MessageBox.Show("Please enter username", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
            }
            if (password.Text == "")
            {
                MessageBox.Show("Please enter password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
            }
            try
            {
                string usr = name.Text;
                string psw = password.Text;

                

                con.Open();
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "select from Users where Username='" + name.Text + "' and Password='" + password.Text + "'";
                OleDbDataReader reader = com1.ExecuteReader();
                
                if (reader.Read())
                
                    

             
             else
             {
                 MessageBox.Show("Username or password is incorrect");
             }


           con.Close();

         }
         catch (Exception ex)
         { 
            MessageBox.Show("Error " + ex); }*/
        
          
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
