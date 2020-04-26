using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BudgCalc.Data_Access_Layer;
using BudgCalc.Business_Layer;
using System.Data.SqlClient;

namespace BudgCalc.Presentation_Layer
{
    public partial class frmAddSource : Form
    {
        public frmAddSource()
        {
            InitializeComponent();
        }

        private void AddSource_Load(object sender, EventArgs e)
        {
            // Fill Combo boxes with possible data for the user to select.
            FillComboBoxes();

            // If Update, make appropriate adjustments and prefill source data.
            if (Global_Variable.sourceID > 0) // TODO in budget, when it is clicked, add the global
            {
                this.Text = "Update Source";
                btnSourceAdd.Text = "&Update";
                // user cannot change only view
                txtSourceID.Enabled = false;
                FillSourceFieldsWithCurrent();

            }
            else // if add new budget item
            {
                // inform customer of ID process.
                this.Text = "Add Source";
                btnSourceAdd.Text = "Add";

                // makes the box disappear
                txtSourceID.Visible = false;
                lblSource.Text = "Source ID generated automatically.";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Add/Update button
        private void button1_Click(object sender, EventArgs e)
        {
            // updating a source first checks if it has been used and if so,
            // creates a new entry and adds a leave date to the old version.
            
            if (string.IsNullOrEmpty(cbBank.Text))
            {
                MessageBox.Show("Please enter a source."); // working.
            }
            else // Valid
            {
                Source sour = new Source();
                sour.SourceName = cbBank.Text;
                if (!string.IsNullOrEmpty(txtSourceID.Text))
                {
                    sour.SourceID = int.Parse(txtSourceID.Text);
                }

                // TODO update
                string addQuery;
                if (Global_Variable.sourceID == 0)
                {
                    addQuery = "sp_Sources_AddSource";
                }
                else
                {
                    addQuery = "sp_Sources_UpdateSources";
                }




                // prepare connection, open, prepare SqlCommand.
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(addQuery, conn);
                // Tell program to use stored procedures.
                cmd.CommandType = CommandType.StoredProcedure;
                // If updating a customer, add ID as a parametre.
                if (Global_Variable.sourceID != 0) 
                {
                    cmd.Parameters.AddWithValue("@SourceID", sour.SourceID);
                }
                //Add parametres.
                cmd.Parameters.AddWithValue("@SourceName", sour.SourceName);

                // Output exists for both add and update now
                
                cmd.Parameters.AddWithValue("@NewSourceID", SqlDbType.Int).Direction = ParameterDirection.Output;
                
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

        private void FillComboBoxes()
        {
            string comboQuery = "SELECT * FROM Sources";
            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(comboQuery, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {
                    // Create and populate new Source object.
                    Source sour = new Source(int.Parse(sdr["SourceID"].ToString()), sdr["SourceName"].ToString());

                    // Add data to combobox and associated listbox.
                    //cbBankID.Items.Add(sour.SourceID); 
                    cbBank.Items.Add(sour.SourceName);
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

        private void FillSourceFieldsWithCurrent()
        {
            // TODO use lb to get value of cb

            string getSource = "SELECT * FROM Sources WHERE SourceID = " + Global_Variable.sourceID;
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            try
            {

                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(getSource, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {

                    Source sour = new Source();
                    sour.SourceID = int.Parse(sdr["SourceID"].ToString());
                    sour.SourceName = sdr["SourceName"].ToString();

                    cbBank.Text = sour.SourceName;
                    txtSourceID.Text = sour.SourceID.ToString();
                    
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

        private void cbBank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int index = cbBank.SelectedIndex; // accurate
            //cbBankID.SelectedItem = index;
            //MessageBox.Show("the index is " + index + " so the item is: " + cbBankID.SelectedItem.ToString());
            //txtSourceID.Text = cbBankID.SelectedItem.ToString();

            // TODO use the second combobox to store and display ID numbers

        }
    }
}
