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
            // TODO error if there is no date. Shouldn't be an issue, it's only an issue because 
            // I added it later.

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

        private void btnAddTrans_Click(object sender, EventArgs e)
        {


            // this update is tricky because it will adjust totals. 
            // TODO once done the totals will need to revisit

            bool isValid = true;
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Please select a date");
                isValid = false;
            }
            if (string.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Please add or select a category");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtAmount.Text) || !txtAmount.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter an amount in numbers only.");
                isValid = false;
            }
            if (string.IsNullOrEmpty(cbSource.Text))
            {
                MessageBox.Show("Please add or select a source");
                isValid = false;
            }
            if (rbCredit.Checked || rbDebit.Checked)
            {
                // nothing
            }
            else
            {
                MessageBox.Show("Please choose whether this earning or spending money.");
                isValid = false;
            }

            if (isValid)
            {
                Transaction tn = new Transaction();
                tn.Amount = int.Parse(txtAmount.Text);
                if (!string.IsNullOrEmpty(txtTransID.Text))
                {
                    tn.TransactionID = int.Parse(txtTransID.Text);
                }
                tn.TransDate = DateTime.Parse(dateTimePicker1.Text);
                tn.SourceID = int.Parse(lbSourceID.Items[cbSource.SelectedIndex].ToString());

                // TEMPLATE int.Parse(lbType.Items[cbType.SelectedIndex].ToString())
               
                tn.CategoryName = cbCategory.Text;
                if (rbCredit.Checked)
                {
                    tn.IsCredit = true;
                }
                else
                {
                    tn.IsCredit = false;
                }


                //MessageBox.Show("what is the source ID? " + tn.SourceID.ToString());

                // Put appropriate stored proc depending on whether new or updated transaction.
                string addQuery;
                if (Global_Variable.transactionID == 0)
                {
                    addQuery = "sp_Transactions_AddTransaction";
                }
                else
                {
                    addQuery = "sp_Transactions_UpdateTransactions";
                }
                // prepare connection, open, prepare SqlCommand.
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(addQuery, conn);
                // Tell program to use stored procedures.
                cmd.CommandType = CommandType.StoredProcedure;
                // If updating a customer, add ID as a parametre.
                if (Global_Variable.transactionID != 0)
                {
                    cmd.Parameters.AddWithValue("@TransactionID", tn.TransactionID);
                }
                // Add parametres.
                cmd.Parameters.AddWithValue("@CategoryID", tn.CategoryID);
                cmd.Parameters.AddWithValue("@Period", Global_Variable.currentPeriod);
                cmd.Parameters.AddWithValue("@SourceID", tn.SourceID);
                cmd.Parameters.AddWithValue("@Amount", tn.Amount);
                cmd.Parameters.AddWithValue("@CreditDebit", tn.IsCredit);
                cmd.Parameters.AddWithValue("@TransDate", tn.TransDate);

                // If new customer, get the output.
                if (Global_Variable.transactionID == 0)
                {
                    cmd.Parameters.AddWithValue("@NewTransactionID", SqlDbType.Int).Direction = ParameterDirection.Output;
                }
                // Use transactions to call database.
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                // Close connection.
                conn.Close();
                // Close window.
                this.Close();


            }
        }
    }
}
