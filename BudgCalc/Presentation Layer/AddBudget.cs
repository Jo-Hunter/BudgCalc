using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BudgCalc.Data_Access_Layer;
using System.Data.SqlClient;
using BudgCalc.Business_Layer;

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
            // klhsihl

            // Fill Combo boxes with possible data for the user to select.
            FillComboBoxes();

            // If Update, make appropriate adjustments and prefill budget data.
            if (Global_Variable.budgetID > 0) // TODO in budget, when it is clicked, add the global
            {
                this.Text = "Update Budget";
                btnAdd.Text = "&Update";
                // user cannot change only view
                tbBudgetID.Enabled = false;
                FillBudgetFieldsWithCurrent();

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
                    cbBank.Items.Add(sour.SourceName);
                    lbBankID.Items.Add(sour.SourceID.ToString());

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
                    cbCatID.Items.Add(cat.CategoryID);
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

        private void FillBudgetFieldsWithCurrent()
        {
            // TODO use lb to get value of cb
            // TODO unhappy with credit/debit need to fix

            tbBudgetID.Text = Global_Variable.budgetID.ToString();

            string getBudget = "SELECT * FROM Categories WHERE CategoryID = " + Global_Variable.budgetID;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            try
            {

                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(getBudget, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {

                    Category cat = new Category();
                    cat.Amount = double.Parse(sdr["AssignedAmount"].ToString());
                    cat.CategoryName = sdr["CategoryName"].ToString();
                    cat.Description = sdr["CategoryDescription"].ToString();
                    cat.SourceID = int.Parse(sdr["SourceID"].ToString());

                    cbCategory.Text = cat.CategoryName;
                    tbAmount.Text = cat.Amount.ToString();
                    lbBankID.Text = cat.SourceID.ToString();
                    tbPurpose.Text = cat.Description;

                    if (cat.Amount < 0)
                    {
                        rbAddDebit.Checked = true;
                    }
                    else
                    {
                        rbAddCredit.Checked = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // TODO 
            // close the changed budget by adding an end date
            // and create a NEW entry with this these details.
            // in order to keep the old budget records

            // First see if can delete, if never used. If never used, update. - no this is budget.
            // if used, add date to old and create a new.


            // NOTE: the sp for update checks to see if it has been used and if so,
            // automatically creates a new entry instead. 
            // However, I haven't made it enter a leavedate yet, next task.
            // Git failed with a fatal error.
            //fatal: Unable to create 'C:/Users/joz/documents/visual studio 2017/Projects/BudgCalc/.git/index.lock': File exists.

            //Another git process seems to be running in this repository, e.g.
            //an editor opened by 'git commit'.Please make sure all processes
            //are terminated then try again.If it still fails, a git process
            //may have crashed in this repository earlier:
            //remove the file manually to continue.

            // addiotnal error when I changed it file and tried again
            //Git failed with a fatal error.
//warning: LF will be replaced by CRLF in BudgCalc / Presentation Layer / AddBudget.cs.
//The file will have its original line endings in your working directory.
//fatal: Unable to create 'C:/Users/joz/documents/visual studio 2017/Projects/BudgCalc/.git/index.lock': File exists.

//Another git process seems to be running in this repository, e.g.
//an editor opened by 'git commit'.Please make sure all processes
//are terminated then try again.If it still fails, a git process
//may have crashed in this repository earlier:
//remove the file manually to continue.

            bool isValid = true;

            if (string.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Please enter or select a category.");
                isValid = false;
            }
            
            if (string.IsNullOrEmpty(tbAmount.Text) || !tbAmount.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter or select a category and use numbers only.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(cbBank.Text))
            {
                MessageBox.Show("Please enter or select a source.");
                isValid = false;
            }
            if (rbAddCredit.Checked || rbAddDebit.Checked)
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
                Category cat = new Category();
                if (!string.IsNullOrEmpty(tbBudgetID.Text))
                {
                    cat.CategoryID = int.Parse(tbBudgetID.Text);
                }
                    
                cat.CategoryName = cbCategory.Text;
                cat.Amount = int.Parse(tbAmount.Text);
                cat.SourceID = int.Parse(lbBankID.Items[cbBank.SelectedIndex].ToString());
                cat.Description = tbPurpose.Text;

                // Put appropriate stored proc depending on whether new or updated customer.
                string addQuery;
                if (Global_Variable.budgetID == 0)
                {
                    addQuery = "sp_Categories_AddCategory";
                }
                else
                {
                    addQuery = "sp_Categories_UpdateCategory";
                }
                // prepare connection, open, prepare SqlCommand.
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(addQuery, conn);
                // Tell program to use stored procedures.
                cmd.CommandType = CommandType.StoredProcedure;
                // If updating a customer, add ID as a parametre.
                if (Global_Variable.budgetID != 0)
                {
                    cmd.Parameters.AddWithValue("@CategoryID", cat.CategoryID);
                }
                // Add parametres.
                cmd.Parameters.AddWithValue("@CategoryName", cat.CategoryName);
                cmd.Parameters.AddWithValue("@AssignedAmount", cat.Amount);
                cmd.Parameters.AddWithValue("@CategoryDescription", cat.Description);
                cmd.Parameters.AddWithValue("@SourceID", cat.SourceID);

                // If new customer, get the output.
                //if (Global_Variable.budgetID == 0)
                //{
                    cmd.Parameters.AddWithValue("@NewCategoryID", SqlDbType.Int).Direction = ParameterDirection.Output;
                //}
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
