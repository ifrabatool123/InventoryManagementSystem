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
    public partial class Registration_Detail : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Registration_Detail()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

            


        }

        private void Registration_Detail_Load(object sender, EventArgs e)
        {

            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Registration ", con);
            DataSet d1 = new DataSet("Registration");
            con.Open();
            adap.Fill(d1, "Registration");
            dataGrid1.DataSource = d1;
            con.Close();
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
