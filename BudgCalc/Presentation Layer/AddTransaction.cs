using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BudgCalc.Business_Layer;
using BudgCalc.Data_Access_Layer;

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
            string comboSourceQuery = "SELECT * from Sources";
            string comboCatQuery = "SELECT * FROM Categories";
            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(comboSourceQuery, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {
                    // Create and populate new Source object.
                    Source sour = new Source(int.Parse(sdr["SourceID"].ToString()), sdr["SourceName"].ToString());
                    // Add data to combobox and associated listbox.
                    cbSource.Items.Add(sour.SourceName);
                    lbSourceID.Items.Add(sour.SourceID.ToString());

                }
                // If the reader was opened, close it.
                if (sdr != null)
                {
                    sdr.Close();
                }

                // Close connection.
                conn.Close();
            }
            catch (Exception ex) // For fill comboboxes.
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
            try
            {
                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(comboCatQuery, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {
                    // Create and populate new Category object.
                    Category cat = new Category();
                    //cat.SourceID = 
                    cat.CategoryID = int.Parse(sdr["CategoryID"].ToString());
                    cat.CategoryName = sdr["CategoryName"].ToString();
                    //Source sour = new Source(int.Parse(sdr["SourceID"].ToString()), sdr["SourceName"].ToString());
                    // Add data to combobox and associated listbox.
                    cbCategory.Items.Add(cat.CategoryName);
                    lbCatID.Items.Add(cat.CategoryID);

                }
                // If the reader was opened, close it.
                if (sdr != null)
                {
                    sdr.Close();
                }

                // Close connection.
                conn.Close();
            }
            catch (Exception ex) // For fill comboboxes.
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
        }

        private void FillTransactionFieldsWithCurrent()
        {
            // TODO use lb to get value of cb

            string getTrans = "SELECT * FROM Transactions WHERE TransactionID = " + Global_Variable.transactionID;
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            try
            {
                
                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(getTrans, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {

                    Transaction tn = new Transaction();
                    tn.TransactionID = int.Parse(sdr["TransactionID"].ToString());
                    tn.TransDate = DateTime.Parse(sdr["TransDate"].ToString());
                    tn.SourceID = int.Parse(sdr["SourceID"].ToString());
                    tn.Amount = double.Parse(sdr["Amount"].ToString());
                    tn.CategoryID = int.Parse(sdr["CategoryID"].ToString());
                    tn.IsCredit = bool.Parse(sdr["CreditDebit"].ToString());

                    dateTimePicker1.Text = tn.TransDate.ToString();
                    txtAmount.Text = tn.Amount.ToString();
                    txtTransID.Text = tn.TransactionID.ToString();
                    lbCatID.Text = tn.CategoryID.ToString();
                    lbSourceID.Text = tn.SourceID.ToString();
                    

                    if (tn.IsCredit)
                    {
                        rbCredit.Checked = true;
                    }
                    else
                    {
                        rbDebit.Checked = true;
                    }
                }
                // If the reader was opened, close it.
                if (sdr != null)
                {
                    sdr.Close();
                }

                // Close connection.
                conn.Close();
            }
            catch (Exception ex) // For fill comboboxes.
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
