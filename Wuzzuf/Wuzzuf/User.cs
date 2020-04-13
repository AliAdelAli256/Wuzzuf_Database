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
        public User()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Insert into USERINFO (firstname, lastname, email, password, phonenumber, typeid) 
                                            values(:firstName, :lastname, :email, :password, :phonenmber, :typeid)";
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
                MessageBox.Show("Registred Succesfully");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string Email = EmailLTextBox.Text;
            string pass = PasswordLTextBox.Text;
            cmd.CommandText = "Select phonenumber from userinfo where email=:email and password=:pass";
            cmd.Parameters.Add("email", Email);
            cmd.Parameters.Add("pass", pass);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                passdatatextbox.Text = pass;
                phonedatatextbox.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
