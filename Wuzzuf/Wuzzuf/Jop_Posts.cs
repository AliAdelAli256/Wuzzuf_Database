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
    public partial class Jop_Posts : Form
    {
        string ordb = "data source=orcl; user id=scott; password=scott;";
        OracleConnection conn;
        string jobPostID = "";

        public Jop_Posts()
        {
            InitializeComponent();
        }

        private void Jop_Posts_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void FilterJobsButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetJobPosts";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("salary", salaryTextBox.Text.ToString());
            cmd.Parameters.Add("years", yearsTextBox.Text.ToString());
            cmd.Parameters.Add("postDate", postDateTimePicker.Value);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            /*
            while (dr.Read())
            {
                for(int i = 0; i < 11; i++)
                {
                    MessageBox.Show(dr[i].ToString());                
                }
            }
            */

            //DataSet tables = new DataSet();
            //OracleDataAdapter Adapter = new OracleDataAdapter(cmd);
            //Adapter.Fill(tables);
            //jobsDataGridView.DataSource = tables.Tables[0];
            jobsDataGridView.DataSource = dataTable;
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            refresh();
        }


        private void JobsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                e.RowIndex < jobsDataGridView.Rows.Count - 1 && e.ColumnIndex < jobsDataGridView.Columns.Count - 1 &&
                jobsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                jobsDataGridView.CurrentRow.Selected = true;
                end_DateTimePicker.Value = DateTime.Parse(jobsDataGridView.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                salary_TextBox.Text = jobsDataGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                title_TextBox.Text = jobsDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                description_TextBox.Text = jobsDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                years_TextBox.Text = jobsDataGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                LoadComboBox(e, city_ComboBox, "SELECT name FROM cities", "SELECT name FROM cities where cityid =: id", 7);
                LoadComboBox(e, jobType_ComboBox, "SELECT typename FROM jobtypes", "SELECT typename FROM jobtypes where jobtypeid =: id", 8);
                LoadComboBox(e, careerType_ComboBox, "SELECT careername FROM careers", "SELECT careername FROM careers where careerid =: id", 10);
                
                jobPostID = jobsDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            }
        }

        void LoadComboBox(DataGridViewCellEventArgs e, ComboBox c1, string s1, string s2, int i1)
        {
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = s1;
            cmd3.CommandType = CommandType.Text;
            OracleDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                c1.Items.Add(dr3[0]);
            }
            dr3.Close();
            cmd3.CommandText = s2;
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("id", jobsDataGridView.Rows[e.RowIndex].Cells[i1].FormattedValue.ToString());
            dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                c1.Text = dr3[0].ToString();
            }
            dr3.Close();
        }

        void refresh() {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT * FROM jobposts";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            //DataSet tables = new DataSet();
            //OracleDataAdapter Adapter = new OracleDataAdapter(cmd);
            //Adapter.Fill(tables);
            //jobsDataGridView.DataSource = tables.Tables[0];
            jobsDataGridView.DataSource = dataTable;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "updatejobpost";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("title1", title_TextBox.Text.ToString());
            cmd.Parameters.Add("description1", description_TextBox.Text.ToString());
            cmd.Parameters.Add("years", int.Parse(years_TextBox.Text.ToString()));
            cmd.Parameters.Add("salary1", int.Parse(salary_TextBox.Text.ToString()));

            string jobtypeid = ReverseLoadComboBox(jobType_ComboBox, "SELECT jobtypeid FROM jobtypes where typename =: name");
            cmd.Parameters.Add("jobtype_id", int.Parse(jobtypeid));

            string careerid = ReverseLoadComboBox(careerType_ComboBox, "SELECT careerid FROM careers where careername =: name");
            cmd.Parameters.Add("career_id", int.Parse(careerid));

            string cityid = ReverseLoadComboBox(city_ComboBox, "SELECT cityid FROM cities where name =: name");
            cmd.Parameters.Add("city_id", int.Parse(cityid));

            cmd.Parameters.Add("endDate", DateTime.Now);

            cmd.Parameters.Add("jobpost_id", jobPostID);

            cmd.ExecuteNonQuery();
            refresh();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertJobPost";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("title1", title_TextBox.Text.ToString());
            cmd.Parameters.Add("description1", description_TextBox.Text.ToString());
            cmd.Parameters.Add("years", int.Parse(years_TextBox.Text.ToString()));
            cmd.Parameters.Add("salary1", int.Parse(salary_TextBox.Text.ToString()));

            string jobtypeid = ReverseLoadComboBox(jobType_ComboBox, "SELECT jobtypeid FROM jobtypes where typename =: name");
            cmd.Parameters.Add("jobtype_id", int.Parse(jobtypeid));

            string careerid = ReverseLoadComboBox(careerType_ComboBox, "SELECT careerid FROM careers where careername =: name");
            cmd.Parameters.Add("career_id", int.Parse(careerid));

            string cityid = ReverseLoadComboBox(city_ComboBox, "SELECT cityid FROM cities where name =: name");
            cmd.Parameters.Add("city_id", int.Parse(cityid));

            // TODO connect to userinfo class in user form 
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from recruiters where RECRUITERID =: userid";
            cmd2.CommandType = CommandType.Text;

            if (User.userInfo != null)
            {
                cmd2.Parameters.Add("userid", int.Parse(User.userInfo.id));
                OracleDataReader dr =  cmd2.ExecuteReader();

                if(!dr.HasRows)
                {
                    MessageBox.Show("Recruiter Not Found");
                    return;
                }
            }
            else
            {
                MessageBox.Show("please login");
                return;
            }

            

            cmd.Parameters.Add("postedby_id", int.Parse("3"));
            cmd.Parameters.Add("postDate", postDateTimePicker.Value);
            cmd.Parameters.Add("endDate", DateTime.Now);

            cmd.ExecuteNonQuery();
            refresh();

        }

        string  ReverseLoadComboBox(ComboBox c1, string s1)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = s1;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", c1.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            string s3 = "";
            while (dr.Read())
            {
                s3 = dr[0].ToString();
            }
            dr.Close();

            return s3;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "deletejobpost";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("jobpost_id", jobPostID);
            cmd.ExecuteNonQuery();
            refresh();

        }
    }
}

/*
create or replace
procedure GetJobPosts (salary in VARCHAR2,
                     years in VARCHAR2,
                     postDate DATE,
                     CID out sys_refcursor)
                                         
as
begin
open CID for
select * from jobposts
where jobposts.salary = TO_NUMBER(salary, '9999.99')
and jobposts.postdate = postdate
and  jobposts.YEARSOFEXPERIENCE = TO_NUMBER(years, '99');
end;
*/