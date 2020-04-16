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
    public partial class frmTransPeriod : Form
    {
        public frmTransPeriod()
        {
            InitializeComponent();
        }

        private void btnSearchTrans_Click(object sender, EventArgs e)
        {
            frmSearchTrans st = new frmSearchTrans();
            st.ShowDialog();
        }

        private void btnTransCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddTrans ad = new frmAddTrans();
            ad.ShowDialog();
        }
    }
}
