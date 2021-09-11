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
    public partial class FormCustomerRecord2 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormCustomerRecord2()
        {
            
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }
            private void FormCustomerRecord2_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GetDatabutt_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from OrderInfo ", con);
            DataSet d1 = new DataSet("OrderInfo");
            con.Open();
            adap.Fill(d1, "OrderInfo");
            dataGrid1.DataSource = d1;
            con.Close();
        }
    }
}
