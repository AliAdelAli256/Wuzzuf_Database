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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewData View = new ViewData();
            View.Show();
        }

        private void openReports_Click(object sender, EventArgs e)
        {
            ChooseReport reports = new ChooseReport();
            reports.Show();
        }

        private void JobPost_btn_Click(object sender, EventArgs e)
        {
            Jop_Posts jobPost = new Jop_Posts();
            jobPost.Show();
        }

        private void Login_register_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            Form3_A_Fun jobType = new Form3_A_Fun();
            jobType.Show();
        }
    }
}
