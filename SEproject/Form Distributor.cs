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
    public partial class Form_Distributor : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form_Distributor()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FormCustomerRecord3 f1 = new FormCustomerRecord3();
            f1.Show();
        }

        private void Form_Distributor_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            
        }

        private void NewB_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textaddress.Text = "";
            textlandmark.Text = "";
            textcity.Text = "";
            comboboxstate.Text = "";
            textzipcode.Text = "";
            textdistributor_id.Text = "";
            textphone.Text = "";
            textemail.Text = "";
            textmobile_no.Text = "";
            textfax_no.Text = "";
            textnotes.Text = "";

        }

        private void textzipcode2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
