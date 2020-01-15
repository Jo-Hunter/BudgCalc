using BudgCalc.Presentation_Layer;
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

namespace BudgCalc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmManager bud = new frmManager();
            //this.Hide();
            bud.ShowDialog();
            

            //this.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSummary sum = new frmSummary();
            

            sum.Show();
            


            

            // and will later do business.
        }

        private void lblSpendAccount_Click(object sender, EventArgs e)
        {
            // this needs to be dynamic to whether they checked spent or earned
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            prefillCategory();
            prefillSource();
        }

        public void prefillCategory()
        {
            string query = "select * from Categories";

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                }
                if (sdr!=null)
                {
                    sdr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void prefillSource()
        {
            string query = "select * from Sources";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                }
                if (sdr != null)
                {
                    sdr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
