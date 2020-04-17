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
        }

        private void FillBudgetFieldsWithCurrent()
        {
            // TODO
            // prefill all the fields using the ID given
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // TODO 
            // close the changed budget by adding an end date
            // and create a NEW entry with this these details.
            // in order to keep the old budget records
        }
    }
}
