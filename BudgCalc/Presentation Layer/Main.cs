using BudgCalc.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BudgCalc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmBudget bud = new frmBudget();
            bud.ShowDialog();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSummary sum = new frmSummary();
            sum.ShowDialog();

            // and will later do business.
        }
    }
}
