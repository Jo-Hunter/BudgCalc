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
            // work out if add or update
            // if add, get the sources
            // if update, get all the fields

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

            bool isValid;

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
        }
    }
}
