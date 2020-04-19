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
   
    public partial class User : Form
    {

        string ordb = "data source=orcl; user id=scott; password=scott;";
        OracleConnection conn;
        UserInfo userInfo;

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            userInfo = new UserInfo();           
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "getmax";
            cmd1.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            int mx = 0;
            cmd1.ExecuteNonQuery();
            try
            {
                mx = Convert.ToInt32(cmd1.Parameters["id"].Value.ToString()) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
                return;
            }


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Insert into USERINFO (userid, firstname, lastname, email, password, phonenumber, typeid) 
                                            values(:id, :firstName, :lastname, :email, :password, :phonenmber, :typeid)";
            cmd.Parameters.Add("id", mx.ToString());
            cmd.Parameters.Add("firstName", firstNameTextBox.Text.ToString());
            cmd.Parameters.Add("lastname", LastNameTextBox.Text.ToString());
            cmd.Parameters.Add("email", EmailTextbox.Text.ToString());
            cmd.Parameters.Add("password", PasswordTextBox.Text.ToString());
            cmd.Parameters.Add("phonenumber", PhoneTextBox.Text.ToString());
            cmd.Parameters.Add("typeid", TypeTextBox.Text.ToString());
            int ret = cmd.ExecuteNonQuery();
            if (ret == -1)
                MessageBox.Show("An error happened!");
            else
            {
                MessageBox.Show("Registred Succesfully");
                clearFields();
            }
            
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            userInfo.email = EmailLTextBox.Text;
            userInfo.pass = PasswordLTextBox.Text;
            cmd.CommandText = "Select * from userinfo where email=:email and password=:pass";
            cmd.Parameters.Add("email", userInfo.email);
            cmd.Parameters.Add("pass", userInfo.pass);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userInfo.id = dr[0].ToString();
                userInfo.fName = dr[1].ToString();
                userInfo.lName = dr[2].ToString();
                userInfo.email = dr[3].ToString();
                userInfo.pass = dr[4].ToString();
                userInfo.phoneNumber = dr[5].ToString();

                passdatatextbox.Text = userInfo.pass;
                updateFNametextBox.Text = userInfo.fName;
                updateLNametextBox.Text = userInfo.lName;
                phonedatatextbox.Text = userInfo.phoneNumber;  
                MessageBox.Show(userInfo.id);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string Email = EmailLTextBox.Text;
            string pass = PasswordLTextBox.Text;

            if (Email != "" && pass != "")
            {
                List<string> commands = new List<string>();


                commands.Add("delete from jobapplications where jobapplications.applicantid = (Select userid from userinfo where email = 'AhmedEmail' and password = '123')");
                commands.Add("delete from applicantskills where applicantskills.applicantid = (Select userid from userinfo where email = 'AhmedEmail' and password = '123')");
                commands.Add("delete from applicants where applicants.applicantid = (Select userid from userinfo where email = 'AhmedEmail' and password = '123')");
                commands.Add("delete from userinfo where userinfo.userid = (Select userid from userinfo where email = 'AhmedEmail' and password = '123')");
                int i=0;
                try
                {
                    for (i = 0; i < commands.Count; i++)
                    {
                        cmd.CommandText = commands[i];
                        cmd.Parameters.Add("email", Email);
                        cmd.Parameters.Add("pass", pass);

                        int r = cmd.ExecuteNonQuery();
                        if (r == -1)                    
                            MessageBox.Show("Something went wrong"); 
                    }

                    MessageBox.Show("User Deleted Successfully");
                    clearFields();

                }catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong: " + i.ToString() + ex.Message); 
                }

            }
            else
            {
                MessageBox.Show("Please Sign In");
            }            
        }

        void clearFields()
        {
            firstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            EmailTextbox.Text = "";
            PasswordTextBox.Text = "";
            PhoneTextBox.Text = "";
            TypeTextBox.Text = "";
        }

        private void EditButton3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Update userinfo set FIRSTNAME=:firstName,
                                                    LASTNAME=:lastName, 
                                                    PASSWORD=:password, 
                                                    PHONENUMBER=:phoneNumber 
                                                    where userinfo.userid=:id";
            cmd.Parameters.Add("firstName", updateFNametextBox.Text.ToString());
            cmd.Parameters.Add("lastName", updateLNametextBox.Text.ToString());
            cmd.Parameters.Add("password", passdatatextbox.Text.ToString());
            cmd.Parameters.Add("phoneNumber", phonedatatextbox.Text.ToString());
            cmd.Parameters.Add("id", userInfo.id);
            int ret = cmd.ExecuteNonQuery();
            if (ret == -1)
                MessageBox.Show("An error happened!");
            else
            {
                MessageBox.Show("Updated User Info Succesfully");
            }
        }
    }
    public class UserInfo
    {
        public string email;
        public string pass;
        public string id;
        public string fName;
        public string lName;
        public string phoneNumber;
    }

}
