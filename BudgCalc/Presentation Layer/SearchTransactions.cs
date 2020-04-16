using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BudgCalc.Presentation_Layer
{
    public partial class frmSearchTrans : Form
    {
        public frmSearchTrans()
        {
            InitializeComponent();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            // TODO send info to a global
            frmTransPeriod tp = new frmTransPeriod();
            tp.ShowDialog();
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
