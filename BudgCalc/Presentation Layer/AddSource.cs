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
            // TODO 
            // validate first
            // create sps
            // send data

            
            if (string.IsNullOrEmpty(cbBank.Text))
            {
                MessageBox.Show("Please enter a source."); // working.
            }
            else // Valid
            {

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
