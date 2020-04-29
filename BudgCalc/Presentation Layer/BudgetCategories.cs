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
    public partial class frmPlan : Form
    {
        public frmPlan()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBudget_Load(object sender, EventArgs e)
        {
            DisplayBudget();
        }

        private void DisplayBudget()
        {

            // If date equals NULL, the budget item is current.
            string query = "SELECT * from Categories WHERE LeaveDate IS NULL";
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
                    // Get data from Categories table
                    int id = int.Parse(sdr["CategoryID"].ToString());
                    string name = sdr["CategoryName"].ToString();
                    double amount = double.Parse(sdr["AssignedAmount"].ToString());
                    string descr = sdr["CategoryDescription"].ToString();
                    int sourceID = int.Parse(sdr["SourceID"].ToString());
                    
                    // Init and populate the Category class
                    Category cat = new Category(id, name, descr, amount, sourceID);


                    // Init the ListView by giving the PK.
                    ListViewItem lvi = new ListViewItem(cat.CategoryID.ToString());
                    // Submit the information going in the other column/s.
                    lvi.SubItems.Add(cat.CategoryName);
                    lvi.SubItems.Add(cat.Amount.ToString());
                    lvi.SubItems.Add(cat.SourceID.ToString());
                    lvi.SubItems.Add(cat.Description);

                    // Add the items to the listview.
                    lvCategories.Items.Add(lvi);
                                 
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int test = int.Parse(lvCategories.SelectedItems[0].Text);
               
                Global_Variable.budgetID = test;

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Global_Variable.budgetID = 0;
            }

            frmAddBudget ab = new frmAddBudget();
            ab.ShowDialog();

            lvCategories.Items.Clear();
            DisplayBudget();

        }

        private void lvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // none
        }

        private void lvCategories_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Is a customer selected? Change AddUpdate button to reflect that.
            if (lvCategories.SelectedItems.Count > 0)
            {
                btnAdd.Text = "&Update";

            }
            else
            {
                btnAdd.Text = "&Add";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ask if sure first
            // if so, get the OUTPUT of the sp and let the user know
            // if it has been deleted or archived


            

            if (lvCategories.SelectedItems.Count > 0)
            {
                string select = lvCategories.SelectedItems[0].SubItems[0].Text;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item " + select + "?", "Delete Budget Category", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    Category cat = new Category();
                    cat.CategoryID = int.Parse(select);

                    

                    //// Put appropriate stored proc
                    string deleteQuery;
                    
                    deleteQuery = "sp_Categories_RemoveCategory";
                   
                    // prepare connection, open, prepare SqlCommand.
                    SqlConnection conn = ConnectionManager.DatabaseConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    // Tell program to use stored procedures.
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add parameters
                    cmd.Parameters.AddWithValue("@CategoryID", cat.CategoryID);


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
