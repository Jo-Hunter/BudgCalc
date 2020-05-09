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
using System.Collections;

namespace BudgCalc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // opens 'adjust budget' window
        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmManager bud = new frmManager();
            bud.ShowDialog();
        }

        // Adds this transaction
        private void btnAdd_Click(object sender, EventArgs e)
        {

            

           // init
            int catID = 0;
            int srcID = 0;
            int amount = 0;
            // this represents the tally arr before this transaction
            List<object[]> objList = Global_Variable.tally_arr;
            // does this transaction require a new entry in the global tally list?
            bool savedToGlobal = false;
            // the array with the details of the current transaction
            // category | source | amount
            object[] entry = new object[3];
            // if there is nothing in the tally arr, this current array will need to be added.
            //if (Global_Variable.tally_arr.Count==0)
            //{
            //    needNew = true;
            //}

            // create Transaction object for data of this transaction.
            Transaction tran = new Transaction();





            // Validation
            bool isValid = true;

            // is the money spent or earned?
            if(rbEarned.Checked)
            {
                tran.IsCredit = true;
            }
            else if (rbSpent.Checked)
            {
                tran.IsCredit = false;
            }
            else // invalid if nothing selected
            {
                MessageBox.Show("Please select whether you have earned or spent this money.");
                isValid = false;
            }
            // if something has been selected in the category combobox
            if (cbCategory.SelectedIndex >= 0)
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
                MessageBox.Show("Please assign the source that this money has come from/arrived at.");
                isValid = false;
            }

            if (double.TryParse(txtAmount.Text, out double result ))
            {

                if (tran.IsCredit)
                {
                    tran.Amount = result;
                }
                else
                {
                    tran.Amount = result*-1;
                }
                
            }
            else
            {
                MessageBox.Show("Please enter the $amount of this transaction.");
                isValid = false;
            }


            if (isValid)
            {

                tran.TransDate = DateTime.Now;

                if (Global_Variable.currentPeriod == 0)
                {
                    // first transaction, create first period upon first valid entry.
                    UpdatePeriod();
                    Global_Variable.currentPeriod = 1;
                    tran.Period = 1;
                    
                }
                else
                {
                    tran.Period = Global_Variable.currentPeriod;
                }



                // are there any entries in the global array already?
                if (objList.Count == 0) // if empty, add this as a new list item.
                {

                    entry[0] = tran.CategoryID;
                    entry[1] = tran.SourceID;
                    entry[2] = tran.Amount;

                    Global_Variable.tally_arr.Add(entry);
                    savedToGlobal = true;
                    SaveTransaction(tran);
                }
                else // otherwise check through list items to see if this category has been added before.
                {
                    // check through all the existing arrays in the global variable
                    for (int i = 0; objList.Count > i; i++)
                    {
                        // if there is another entry in the same category, I need to update 
                        // with the new figure, but otherwise I add a new list item array.
                        if ((int)(objList[i][0]) == tran.CategoryID)
                        {
                          
                            // i = objList.Count + 1;
                         
                            if ((int)(objList[i][1]) == tran.SourceID)
                            {
                                
                                double tot;
                                double curr = double.Parse(objList[i][2].ToString());                               

                                tot = curr + tran.Amount;
                                Global_Variable.tally_arr[i][2]= tot;

                                savedToGlobal = true;
                                SaveTransaction(tran);
                            }
                        }
                        
                        
                    }
                    // if no match was found in both category & source, create new.
                    if (!savedToGlobal)
                    {
                        entry[0] = tran.CategoryID;
                        entry[1] = tran.SourceID;
                        entry[2] = tran.Amount;

                        Global_Variable.tally_arr.Add(entry);
                        savedToGlobal = true;
                        SaveTransaction(tran);
                    }
                }
                Global_Variable.transact = tran;
                frmSummary sum = new frmSummary();
                sum.Show();
            }
            else
            {
                MessageBox.Show("Fix the errors in this transaction and try again.");
            }       

           


            // and will later do business.
        }

        private void SaveTransaction(Transaction t)
        {
            Transaction tran = t;
            
            
            // TODO insert transaction into table using SP
            // Put appropriate stored proc depending on whether new or updated customer.


            string addQuery;
            
            addQuery = "sp_Transactions_AddTransaction";
            
            // prepare connection, open, prepare SqlCommand.
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);
            // Tell program to use stored procedures.
            cmd.CommandType = CommandType.StoredProcedure;

            // Add parametres.
            cmd.Parameters.AddWithValue("@SourceID", tran.SourceID);
            cmd.Parameters.AddWithValue("@Period", tran.Period);
            cmd.Parameters.AddWithValue("@Amount", tran.Amount);
            cmd.Parameters.AddWithValue("@CreditDebit", tran.IsCredit);
            cmd.Parameters.AddWithValue("@CategoryID", tran.CategoryID);
            cmd.Parameters.AddWithValue("@TransDate", tran.TransDate);
            
            // get the output.
            
            cmd.Parameters.AddWithValue("@NewTransactionID", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            // Use transactions to call database.
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();
            // Close connection.
            conn.Close();
            // Close window.
            //this.Close();
        }

        private void UpdatePeriod()
        {

            // TODO should be able to choose a date.
            // Imagine doing the budget, you wouldn't always be able to do it on the right day but
            // usually budgets are weekly or fortnightly etc for comparison.
            // OR should I allow th users to set a start date and timeframe?
            // like the banks, scheduling auto payments
            // eg fortnightly from 11/4/20
            // now I'm thinking how it would work with the Periods table if it was set on auto.
            // I suppose some kind of check on load, what is the date, get the last date, 
            // add periods on load. 
            // I don't think I can do away with the Periods table because
            // I need to keep the functionality to change timeframes etc.
            // or do I need to use this method at all, can't I just ues dates now?
            // since I added dates in all the tables?
            // Okay food for thought.

            int per = Global_Variable.currentPeriod;
            
            string addQuery;

            addQuery = "sp_Periods_AddPeriod";

            // prepare connection, open, prepare SqlCommand.
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);
            // Tell program to use stored procedures.
            cmd.CommandType = CommandType.StoredProcedure;

            // Add parametres.
            cmd.Parameters.AddWithValue("@Period", per);
            cmd.Parameters.AddWithValue("@NewPeriodID", SqlDbType.Int).Direction = ParameterDirection.Output;

            // Use transactions to call database.
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();
            // Close connection.
            conn.Close();
            // Close window.
            this.Close();
            MessageBox.Show("after updating the period... " + Global_Variable.currentPeriod.ToString());
        }

        private void lblSpendAccount_Click(object sender, EventArgs e)
        {
            // this needs to be dynamic to whether they checked spent or earned
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PrefillCategoryCB();
            PrefillSource();

            FindPeriod();

            var tally = new List<object[]>();

            Global_Variable.tally_arr = tally;
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

        private void FindPeriod()
        {

            Global_Variable.currentPeriod = 1;

            //the below is the actual code, just removing a varioable to further test
            //transaction

            string findQuery;
            findQuery = "sp_Periods_GetPeriod";
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(findQuery, conn);

            // this is how you get the output
            object result = cmd.Parameters.AddWithValue("@CurrentPeriod", SqlDbType.Int).Direction = ParameterDirection.Output;
            

            if (result != null)
            {
                int ans = Convert.ToInt32(result);
                Global_Variable.currentPeriod = ans;
                //MessageBox.Show("result = " + ans);
            }
            else
            {
                // this should only ever happen once... but the first time it's ran, it needs this
                Global_Variable.currentPeriod = 0;
                MessageBox.Show(Global_Variable.currentPeriod.ToString());

                // TODO would my sp create an error if it returned null?
                // my thoughts are that if so, I would need to call a period exists sp and then the get period 
                // or could I do that as part of current sp?
                // if null, make 0.

                // to test I would need to drop the periods in the table. Do this after I build periods in.
            }

            conn.Close();


        }

        private void sourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSource sou = new frmSource();
            sou.Show();

            
            
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlan bdg = new frmPlan();
            bdg.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManager mgr = new frmManager();
            mgr.Show();
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            // create a new period
            Global_Variable.currentPeriod = Global_Variable.currentPeriod + 1;
            UpdatePeriod();
        }
    }
}
