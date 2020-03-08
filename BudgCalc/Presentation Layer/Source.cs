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
            string query = "SELECT * from Sources";
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
    }
}
