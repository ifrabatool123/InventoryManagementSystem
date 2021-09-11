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
    public partial class FormVendorRecord : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormVendorRecord()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Vendor ", con);
            DataSet d1 = new DataSet("Vendor");
            con.Open();
            adap.Fill(d1, "Vendor");
            dataGrid1.DataSource = d1;
            con.Close();
        }
    }
}
