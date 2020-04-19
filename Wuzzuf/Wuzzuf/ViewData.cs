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
        string cmd = "";
        OracleDataAdapter Adapter;
        DataSet tables;
        OracleCommandBuilder CmdBuilder;
        public ViewData()
        {
            InitializeComponent();
        }

        private void Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = "SELECT * FROM " + tableName.SelectedItem.ToString() + ";";

            Adapter = new OracleDataAdapter(cmd, conn);
            tables = new DataSet();
            Adapter.Fill(tables);
            columnName.Items.Clear();

            for (int i = 0; i < tables.Tables[0].Columns.Count; i++)
            {
                columnName.Items.Add(tables.Tables[0].Columns[i].ToString());
            }
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            cmd = "SELECT table_name FROM user_tables;";

            Adapter = new OracleDataAdapter(cmd, conn);
            tables = new DataSet();
            Adapter.Fill(tables);

            for (int i = 0; i < tables.Tables[0].Rows.Count; i++)
            {
                tableName.Items.Add(tables.Tables[0].Rows[i][0].ToString());
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (tableName.SelectedIndex > -1 && columnName.SelectedIndex == -1)
            {
                cmd = "SELECT * FROM " + tableName.SelectedItem.ToString() + ";";
            }
            else if (tableName.SelectedIndex > -1 && columnName.SelectedIndex > -1 && string.IsNullOrEmpty(conditionValue.Text))
            {
                cmd = "SELECT " + columnName.SelectedItem.ToString() + " FROM " + tableName.SelectedItem.ToString();
            }
            else if (tableName.SelectedIndex > -1 && columnName.SelectedIndex > -1 && !string.IsNullOrEmpty(conditionValue.Text))
            {
                cmd = "SELECT * FROM " + tableName.SelectedItem.ToString() + " where " + columnName.SelectedItem.ToString() + " = " + "\'" + conditionValue.Text.ToString() + "\'";
            }
            Adapter = new OracleDataAdapter(cmd, conn);
            tables = new DataSet();
            Adapter.Fill(tables);
            rowsSelected.DataSource = tables.Tables[0];
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                CmdBuilder = new OracleCommandBuilder(Adapter);
                Adapter.Update(tables.Tables[0]);
                MessageBox.Show("Changes saved.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
