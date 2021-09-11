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
    public partial class Main : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Main()
        {
            InitializeComponent();
           
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:/inventorysystem (1).accdb";
        }
       
        private void Main_Load(object sender, EventArgs e)
        {
           
            
           
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            FormProduct f1 = new FormProduct();
            f1.Show();
            

        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormVendor f1 = new FormVendor();
            f1.Show();
        }

        private void distributorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Form_Distributor f1 = new Form_Distributor();
            f1.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration f1 = new Registration();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStock f1 = new FormStock();
            f1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTitle f1 = new FormTitle();
            f1.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrder f1 = new FormOrder();
            f1.Show();
            
        }

        private void stock_in_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Stock ", con);
            DataSet d1 = new DataSet("Stock");
            con.Open();
            adap.Fill(d1, "Stock");
            dataGrid1.DataSource = d1;
            con.Close();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
