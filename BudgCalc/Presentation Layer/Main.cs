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
using BudgCalc.Business_Layer;

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


       
            // validate then save the the details in an object
            Transaction tran = new Transaction();
            bool isValid = true;

            if (rbEarned.Checked)
            {
                tran.IsCredit = true;
            }
            else if (rbSpent.Checked)
            {
                tran.IsCredit = false;
            }
            else
            {
                MessageBox.Show("Please select whether you have earned or spent this money.");
                isValid = false;
            }

            if (cbCategory.SelectedIndex>=0)
            {
                // +1 cb index starts at 0, databsae starts at 1
                tran.CategoryID = int.Parse(cbCategory.SelectedIndex.ToString()) + 1;
               
            }
            else
            {
                MessageBox.Show("Please assign the budget category that this money represents.");
                isValid = false;
            }

            if (cbAccount.SelectedIndex>=0)
            {
                tran.SourceID = int.Parse(cbAccount.SelectedIndex.ToString()) + 1;
            }
            else
            {
                MessageBox.Show("Please select the account where this money ACTUALLY was spent from or " +
                    "arrived into.");
                isValid = false;
            }

            if (double.TryParse(txtAmount.Text, out double result))
            {
                // I am hoping this is true if a double
                tran.Amount = double.Parse(txtAmount.Text);
            }
            else
            {
                MessageBox.Show("So this should pop up if the amount box is not a number");
                isValid = false;
            }

            

            if (isValid==true)
            {
                Global_Variable.transact = tran;
                frmSummary sum = new frmSummary();
                sum.Show();
            }
            else
            {
                MessageBox.Show("so the isvalid turned out to be false");
                isValid = true;
            }
          




            
            

            
            


            

            // and will later do business.
        }

        private void lblSpendAccount_Click(object sender, EventArgs e)
        {
            // this needs to be dynamic to whether they checked spent or earned
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PrefillCategoryCB();
            PrefillSource();
        }

        public void PrefillCategoryCB()
        {
            string query = "SELECT * FROM Categories";

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
               
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {
                    //MessageBox.Show("this is reading the sdr");
                    Category cat = new Category()
                    {
                        //CategoryID = sdr["CategoryID"].ToString(), // cast not correct
                        CategoryName = sdr["CategoryName"].ToString()
                    };
                    //cat.Amount = sdr.["AssignedAmount"].ToString();
                    //cat.Description = sdr.["CategoryDescription"];
                    //cat.SourceID = sdr.["SourceID"].toString();

                    cbCategory.Items.Add(cat.CategoryName);
                }
                
                if (sdr!=null)
                {
                    sdr.Close();
                }
                //MessageBox.Show("this is trying the thing after while");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void PrefillSource()
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
                    Source source = new Source();
                    source.SourceName = sdr["SourceName"].ToString();

                    cbAccount.Items.Add(source.SourceName);
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
