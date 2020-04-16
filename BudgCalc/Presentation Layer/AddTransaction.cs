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
    public partial class frmAddTrans : Form
    {
        public frmAddTrans()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddTrans_Load(object sender, EventArgs e)
        {
            FillComboBoxes();

            // If Update, make appropriate adjustments and prefill transaction data.
            if (Global_Variable.transactionID > 0) // TODO in transaction, when it is clicked, add the global
            {
                this.Text = "Update Transaction";
                btnAddTrans.Text = "&Update";

                // user cannot change only view
                txtTransID.Enabled = false;
                
                FillTransactionFieldsWithCurrent();

            }
            else // if add new budget item
            {
                // inform customer of ID process.
                this.Text = "Add Transaction";
                btnAddTrans.Text = "Add";

                // makes the box disappear
                txtTransID.Visible = false;
                lblTransID.Text = "Transaction ID generated automatically.";
                

            }
        }

        private void FillComboBoxes()
        {
            // TODO
        }

        private void FillTransactionFieldsWithCurrent()
        {
            // TODO
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
