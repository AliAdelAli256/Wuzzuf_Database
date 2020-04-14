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
    public partial class ChooseReport : Form
    {
        public ChooseReport()
        {
            InitializeComponent();
        }

        private void showReport_Click(object sender, EventArgs e)
        {
            if (AverageSalary.Checked)
            {
                AverageSalartyForm report = new AverageSalartyForm();
                report.Show();
            }
            else if (JobPosts.Checked)
            {
                JobsReportsForm report = new JobsReportsForm();
                report.Show();
            }
            else
            {
                DaysLeftForm report = new DaysLeftForm();
                report.Show();
            }


            this.Close();
        }
    }
}
