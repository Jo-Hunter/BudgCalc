using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BudgCalc;

namespace BudgCalc.Presentation_Layer
{
    public partial class frmAddBudget : Form
    {
        public frmAddBudget()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddBudget_Load(object sender, EventArgs e)
        {
            // work out if add or update
            // if add, get the sources
            // if update, get all the fields

            // Fill Combo boxes with possible data for the user to select.
            //FillComboBoxes();

            // If Update, make appropriate adjustments and prefill budget data.
            if (Global_Variable.budgetID > 0)
            {
                this.Text = "Update Budget";
                btnAdd.Text = "&Update";
                // user cannot change only view
                tbBudgetID.Enabled = false;
                //FillCustomerFieldsWithCurrent();

            }
            else // if add new budget item
            {
                // inform customer of ID process.
                this.Text = "Add Budget";
                btnAdd.Text = "Add";
                // makes the box disappear
                tbBudgetID.Visible = false;
                lblAddBudget.Text = "Budget ID generated automatically.";
                
            }
        }
    }
}
