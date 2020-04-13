using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Wuzzuf
{
    public partial class Form3_A_Fun : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        string selectedColumn;

        public Form3_A_Fun()
        {
            InitializeComponent();




        }

        private void showCompaniesButton_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select COMPANYNAME from companies";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                selectColumnComboBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void SelectColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
