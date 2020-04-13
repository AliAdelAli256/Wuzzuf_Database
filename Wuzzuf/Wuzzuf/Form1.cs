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

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form2 edit = new Form2();
            edit.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewData View = new ViewData();
            View.Show();
        }
    }
}
