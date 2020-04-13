using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuzzuf
{
    public partial class ViewData : Form
    {
        string conn = "Data Source=orcl; User ID=scott; Password=scott;";
        public ViewData()
        {
            InitializeComponent();
        }

        private void Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM " + tableName.SelectedItem.ToString() + ";";

            DataSet tables = new DataSet();
            OracleDataAdapter Adapter = new OracleDataAdapter(cmd, conn);
            Adapter.Fill(tables);
            columnName.Items.Clear();

            for (int i = 0; i < tables.Tables[0].Columns.Count; i++)
            {
                columnName.Items.Add(tables.Tables[0].Columns[i].ToString());
            }
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT table_name FROM user_tables;";

            DataSet tables = new DataSet();
            OracleDataAdapter Adapter = new OracleDataAdapter(cmd, conn);
            Adapter.Fill(tables);

            for (int i = 0; i < tables.Tables[0].Rows.Count; i++)
            {
                tableName.Items.Add(tables.Tables[0].Rows[i][0].ToString());
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM " + tableName.SelectedItem.ToString() +" where " + columnName.SelectedItem.ToString() + " = " + "\'" +conditionValue.Text.ToString() + "\'";

            DataSet tables = new DataSet();
            OracleDataAdapter Adapter = new OracleDataAdapter(cmd, conn);
            Adapter.Fill(tables);
            rowsSelected.DataSource = tables.Tables[0];
        }
    }
}
