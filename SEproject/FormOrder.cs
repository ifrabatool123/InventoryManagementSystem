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
    public partial class FormOrder : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormOrder()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderRecord1 f1 = new FormOrderRecord1();
            f1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomerRecord2 f1 = new FormCustomerRecord2();
            f1.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchProduct f1 = new FormSearchProduct();
            f1.Show();
            
        }

        private void SaveB2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into OrderInfo values('" + textORDERNO.Text + " ', ' " +dateTimePicker1.Value + " ',' " + comboSTATUS.SelectedIndex + " ',' " + textDID.Text + " ',' " + textDNAME.Text + " ' )";
             
            cmd.ExecuteNonQuery();
           // cmd.CommandText = "insert into OrderedProduct values('" + textPCODE.Text + " ', ' " + PNAME.Text + " ',' " + weightC1.Text + " ',' " + textUPRICE.Text + " ',' " + textACARTONS.Text + " ',' " + textAPACKETS.Text + " ',' " + textCARTONS.Text + " ',' " + textTPACKESTS.Text + " ',' " + textTAMOUNT.Text + " ')";
            
            MessageBox.Show("One record has been added");
            con.Close();

           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateB3_Click(object sender, EventArgs e)
        {

        }

        private void NewB1_Click(object sender, EventArgs e)
        {
            textORDERNO.Text = ""; ;
            comboSTATUS.Text = "";
            textDID.Text = "";
            textDNAME.Text = "";
            textPCODE.Text = "";
            PNAME.Text = ""; 
            weightC1.Text = "";
            textUPRICE.Text = ""; 
            textACARTONS.Text = ""; 
            textAPACKETS.Text = "";
            textCARTONS.Text = ""; 
            textTPACKESTS.Text = ""; 
            textTAMOUNT.Text = "";
        }

        private void comboSTATUS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ODetail_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
           //cmd.CommandText = "insert into OrderInfo values('" + textORDERNO.Text + " ', ' " + comboSTATUS.SelectedIndex + " ',' " + textDID.Text + " ',' " + textDNAME.Text + " ' )";
             cmd.CommandText = "insert into OrderedProduct values('" + textPCODE.Text + " ', ' " + PNAME.Text + " ',' " + weightC1.Text + " ',' " + textUPRICE.Text + " ',' " + textACARTONS.Text + " ',' " + textAPACKETS.Text + " ',' " + textCARTONS.Text + " ',' " + textTPACKESTS.Text + " ',' " + textTAMOUNT.Text + " ')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("One record has been added");
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormOrderRecord1 f1 = new FormOrderRecord1();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCustomerRecord2 f1 = new FormCustomerRecord2();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormSearchProduct f1 = new FormSearchProduct();
            f1.Show();
        }
    }
}
