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
    public partial class DaysLeftForm : Form
    {
        TimeToApply report;
        public DaysLeftForm()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Now;
            }

            report.SetParameterValue(0, dateTimePicker1.Value);
            crystalReportViewer1.ReportSource = report;
        }

        private void DaysLeftForm_Load(object sender, EventArgs e)
        {
            report = new TimeToApply();
        }
    }
}
