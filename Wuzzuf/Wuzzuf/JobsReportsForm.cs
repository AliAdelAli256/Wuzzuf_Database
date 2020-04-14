using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Wuzzuf
{
    public partial class JobsReportsForm : Form
    {

        JobPostsReport jobReports;

        public JobsReportsForm()
        {
            InitializeComponent();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            jobReports.SetParameterValue(0, companiesList.Text);
            crystalReportViewer.ReportSource = jobReports;

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            jobReports = new JobPostsReport();
            foreach (ParameterDiscreteValue company in jobReports.ParameterFields[0].DefaultValues)
            {
                companiesList.Items.Add(company.Value);
            }
        }
    }
}
