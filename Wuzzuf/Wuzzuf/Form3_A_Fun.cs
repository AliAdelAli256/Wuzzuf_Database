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
        string ordb = "data source=orcl; user id=scott; password=scott;";
        OracleConnection conn;
        string selectedColumn;

        public Form3_A_Fun()
        {
            InitializeComponent();
        }

        private void showCompaniesButton_Click(object sender, EventArgs e)
        {         
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_A_Fun_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select TYPENAME from JOBTYPES";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                jobTypesComboBox.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT * FROM jobposts
                                WHERE jobtypeid = (Select JOBTYPEID FROM jobtypes Where typename = :jobtype)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("jobtype", jobTypesComboBox.Items[jobTypesComboBox.SelectedIndex].ToString());
            DataSet tables = new DataSet();
            OracleDataAdapter Adapter = new OracleDataAdapter(cmd);
            Adapter.Fill(tables);
            DataGrid.DataSource = tables.Tables[0];
        }
    }
}
