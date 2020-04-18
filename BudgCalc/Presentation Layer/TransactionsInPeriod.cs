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
    public partial class frmTransPeriod : Form
    {
        public frmTransPeriod()
        {
            InitializeComponent();
        }

        private void btnSearchTrans_Click(object sender, EventArgs e)
        {
            frmSearchTrans st = new frmSearchTrans();
            st.ShowDialog();
        }

        private void btnTransCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                int test = int.Parse(lvTransactions.SelectedItems[0].Text);
                Global_Variable.transactionID = test;

               
            }
            catch (ArgumentOutOfRangeException ex)
            {
               Global_Variable.transactionID = 0;
            }

            frmAddTrans ad = new frmAddTrans();
            ad.ShowDialog();
        }

        private void frmTransPeriod_Load(object sender, EventArgs e)
        {
            DisplayTransactions();
        }

        private void DisplayTransactions()
        {

            // TODO date is all wrong...
            // TODO needs formatting badly

            string query = "SELECT * from Transactions";
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
                    //int id = int.Parse(sdr["SourceID"].ToString());
                    //string name = sdr["SourceName"].ToString();
                    int id = int.Parse(sdr["TransactionID"].ToString());
                    int sourceid = int.Parse(sdr["SourceID"].ToString());
                    double amount = double.Parse(sdr["Amount"].ToString());
                    bool isCredit =bool.Parse(sdr["CreditDebit"].ToString());
                    int catid = int.Parse(sdr["CategoryID"].ToString());
                    int period = int.Parse(sdr["Period"].ToString());
                    string datestring = sdr["TransDate"].ToString();
                    string catname = "";
                    string description = "";
                    DateTime jj = DateTime.Parse(DateTime.Now.ToString());

                    // Init and populate the Sources class
                    Transaction tn = new Transaction(id, catid, catname,description, amount, 
                        sourceid, period, isCredit, jj);

                    string debcred;

                    if (tn.IsCredit)
                    {
                        debcred = "credit";
                    }
                    else
                    {
                        debcred = "debit";
                    }


                    // Init the ListView by giving the PK.
                    ListViewItem lvi = new ListViewItem(tn.TransactionID.ToString());
                    // Submit the information going in the other column/s.
                    lvi.SubItems.Add(datestring);
                    lvi.SubItems.Add(tn.CategoryID.ToString());
                    lvi.SubItems.Add(tn.Amount.ToString());
                    lvi.SubItems.Add(tn.SourceID.ToString());
                    lvi.SubItems.Add(debcred);

                    // Add the items to the listview.
                    lvTransactions.Items.Add(lvi);
                    
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

        private void lvTransactions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Is a customer selected? Change AddUpdate button to reflect that.
            if (lvTransactions.SelectedItems.Count > 0)
            {
                btnUpdate.Text = "&Update";
                
            }
            else
            {
                btnUpdate.Text = "&Add";
                
            }
        }
    }
}
