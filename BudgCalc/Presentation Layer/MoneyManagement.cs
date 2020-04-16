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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void bankMoneyStartsFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSource source = new frmSource();
            
            source.ShowDialog();

           
        }

        private void budgetCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlan budget = new frmPlan();
           
            budget.ShowDialog();

           
        }

        private void btnCancelM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            frmSearchTrans st = new frmSearchTrans();
            st.ShowDialog();
        }
    }
}
