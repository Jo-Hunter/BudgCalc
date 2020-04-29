using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BudgCalc.Data_Access_Layer;
using BudgCalc.Business_Layer;

namespace BudgCalc.Presentation_Layer
{
    public partial class frmSource : Form
    {
        public frmSource()
        {
            InitializeComponent();
        }

        private void btnSourceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSource_Load(object sender, EventArgs e)
        {
            DisplaySource();
        }

        private void DisplaySource()
        {
            string query = "SELECT * from Sources WHERE LeaveDate IS NULL";
            // Init the connection.
            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                // Open the connection.
                conn.Open();
                // Init the SqlCommand with the query and the connection. 
                SqlCommand cmd = new SqlCommand(query, conn);

                // Init the reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop each row.
                while (sdr.Read())
                {
                    // Get data from Sources table
                    int id = int.Parse(sdr["SourceID"].ToString());
                    string name = sdr["SourceName"].ToString();


                    // Init and populate the Sources class
                    Source sou = new Source(id, name);

                    // Init the ListView by giving the PK.
                    ListViewItem lvi = new ListViewItem(sou.SourceID.ToString());

                    
                    
                    // Submit the information going in the other column/s.
                    lvi.SubItems.Add(sou.SourceName);

                    // Add the items to the listview.
                    lvSource.Items.Add(lvi);
                }

                // If the reader has been opened.
                if (sdr != null)
                {
                    // Close it.
                    sdr.Close();
                }
                // Close the connection.
                conn.Close();
            }
            catch (Exception ex) // For selecting the customer data
            {
                // If something goes wrong, show the stack.
                MessageBox.Show("Unsuccessful " + ex);
            }
        }

        private void btnSourceAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int test = int.Parse(lvSource.SelectedItems[0].Text);
                Global_Variable.sourceID = test;


            }
            catch (ArgumentOutOfRangeException ex)
            {
                Global_Variable.sourceID = 0;
            }

            frmAddSource source = new frmAddSource();
            source.ShowDialog();

            lvSource.Items.Clear();
            DisplaySource();

        }

        private void lvSource_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Is a customer selected? Change AddUpdate button to reflect that.
            if (lvSource.SelectedItems.Count > 0)
            {
                btnSourceAdd.Text = "&Update";

            }
            else
            {
                btnSourceAdd.Text = "&Add";

            }
        }

        private void btnSourceDelete_Click(object sender, EventArgs e)
        {
            // ask if sure first
            // if so, get the OUTPUT of the sp and let the user know
            // if it has been deleted or archived




            if (lvSource.SelectedItems.Count > 0)
            {
                string select = lvSource.SelectedItems[0].SubItems[0].Text;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item #" + select + "?", "Delete Source", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    Category cat = new Category();
                    cat.CategoryID = int.Parse(select);

                    Source sou = new Source();
                    sou.SourceID = int.Parse(select);


                    //// Put appropriate stored proc
                    string deleteQuery;

                    deleteQuery = "sp_Sources_RemoveSource";

                    // prepare connection, open, prepare SqlCommand.
                    SqlConnection conn = ConnectionManager.DatabaseConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    // Tell program to use stored procedures.
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add parameters
                    cmd.Parameters.AddWithValue("@SourceID", sou.SourceID);


                    // get the output.    
                    cmd.Parameters.AddWithValue("@Deleted", SqlDbType.Int).Direction = ParameterDirection.Output;


                    // Use transactions to call database.
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    string returnOutput = cmd.Parameters["@Deleted"].Value.ToString();
                    // Close connection.
                    conn.Close();
                    // Close window.
                    this.Close();

                    if (int.Parse(returnOutput) == 0)
                    {
                        MessageBox.Show("This entry has previously been used. Therefore entry has been archived.");
                    }
                    else
                    {
                        MessageBox.Show("This entry has been deleted.");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete");
            }
        }
    }
}
