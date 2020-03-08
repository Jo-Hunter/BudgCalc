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
    public partial class frmBudget : Form
    {
        public frmBudget()
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
            string query = "SELECT * from Categories";
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
    }
}
