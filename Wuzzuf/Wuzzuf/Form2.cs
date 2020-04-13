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

    public partial class Form2 : Form
    {
        OracleDataAdapter Adapter;
        OracleCommandBuilder CmdBuilder;
        DataSet DS;
        public Form2()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Load_Information_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "Data Source=orcl; User ID=scott; Password=scott;";
                string cmd = "";
                if (companiesCheckBox.Checked)
                {
                    cmd = "select * from COMPANIES";
                }
                else if(applicantsCheckBox.Checked)
                {
                    cmd = "select * from APPLICANTS";
                }
                else if (AdminsChechkbox.Checked)
                {
                    cmd = "select * from ADMINS";
                }
                else if (RecruitersChechkbox.Checked)
                {
                    cmd = "select * from RECRUITERS";
                }
                else if(USERINFO.Checked)
                {
                    cmd = "select * from USERINFO";
                }
                Adapter = new OracleDataAdapter(cmd, conn);
                DS = new DataSet();
                Adapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                CmdBuilder = new OracleCommandBuilder(Adapter);
                Adapter.Update(DS.Tables[0]);
                MessageBox.Show("Changes saved.");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void USERINFO_CheckedChanged(object sender, EventArgs e)
        {
            if(USERINFO.Checked)
            {
                applicantsCheckBox.Enabled = true;
                companiesCheckBox.Enabled = true;
                AdminsChechkbox.Enabled = true;
                RecruitersChechkbox.Enabled = true;
            }
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void JOBPOSTS_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
