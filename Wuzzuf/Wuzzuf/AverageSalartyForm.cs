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
    public partial class AverageSalartyForm : Form
    {
        AvgSalary report;
        public AverageSalartyForm()
        {
            InitializeComponent();
            report = new AvgSalary();
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
