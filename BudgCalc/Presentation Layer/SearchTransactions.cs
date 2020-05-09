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
    public partial class frmSearchTrans : Form
    {
        public frmSearchTrans()
        {
            InitializeComponent();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            // TODO send info to a global
            frmTransPeriod tp = new frmTransPeriod();
            tp.ShowDialog();
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // no filter
        private void btnAll_Click(object sender, EventArgs e)
        {
            frmTransPeriod tp = new frmTransPeriod();
            tp.ShowDialog();
        }

        private void frmSearchTrans_Load(object sender, EventArgs e)
        {
            // prepare the form with options. 
            Prefills();
        }

        private void Prefills()
        {
            // TODO give eariest date?
            string periodQuery = "SELECT * from Periods";
            //string startDateQuery = "SELECT TransDate FROM Transactions";
            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                // Open connection.
                conn.Open();
                // Init SqlCommand method with query and connection.
                SqlCommand cmd = new SqlCommand(periodQuery, conn);
                // Init reader.
                SqlDataReader sdr = cmd.ExecuteReader();
                // Loop through each row.
                while (sdr.Read())
                {
                    // Create and populate new Transaction object.
                    Transaction trans = new Transaction();
                    trans.Period = int.Parse(sdr["Period"].ToString());

                    


                    cbPeriodSelect.Items.Add(trans.Period);

                   

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
    }
}
