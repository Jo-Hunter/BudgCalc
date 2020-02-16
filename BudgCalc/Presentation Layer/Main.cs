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

            // so get the period from the database and 
            // save the data into Transaction database

            // i probably need a class for calculating the period. No probably need to access the database
            // when I display the 

            // I want to add an array to my array if the budget category is different or source.


            //int arr_length = Global_Variable.tally_arr.GetLength(0) + 1;
            //Console.Write("arr_length " + arr_length);
            //Console.WriteLine();

            //int[] entry = { 1, 1, 3 };

            //Global_Variable.tally_arr[arr_length][] = Global_Variable.tally_arr + entry;

            //Array.Resize(ref array, newsize);
            //array[newsize - 1] = "newvalue"
            //var i = new List<int[]>();
            //int[] entry = { 1, 0, 92 };

            //var i = Global_Variable.tally_arr.Add(, entry);
            ////i = i.Add(entry);


            //int j = 9;
            //Global_Variable.tally_arr = i.Add(entry);

            //List<string[]> logList = new List<string[]>();
            //logList.Add(new string[] { "item 1", "item 2", "item 3" });

            //List<int[]> objList = new List<int[]>();
            //objList.Add(new int[] { 1, 0, 2});

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
                tran.Amount = result;
            }
            else
            {
                MessageBox.Show("Please enter the $amount of this transaction.");
                isValid = false;
            }


            if (isValid)
            {

                // are there any entries in the global array already?
                if (objList.Count == 0) // if empty, add this as a new list item.
                {

                    entry[0] = tran.CategoryID;
                    entry[1] = tran.SourceID;
                    entry[2] = tran.Amount;

                    Global_Variable.tally_arr.Add(entry);
                    savedToGlobal = true;
                }
                else // otherwise check through list items to see if this category has been added before.
                {
                    // check through all the existing arrays in the global variable
                    for (int i = 0; objList.Count >= i; i++)
                    {
                        // if there is another entry in the same category, I need to update 
                        // with the new figure, but otherwise I add a new list item array.
                        if ((int)(objList[i][0]) == tran.CategoryID)
                        {
                            // 
                            // i = objList.Count + 1;
                            // TODO now check if the source is the same.
                            if ((int)(objList[i][1]) == tran.SourceID)
                            {
                                // TODO need to update amount here
                                savedToGlobal = true;
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

            //if (cbAccount.SelectedIndex>=0)
            //{
            //    tran.SourceID = int.Parse(cbAccount.SelectedIndex.ToString()) + 1;
            //}
            //else
            //{
            //    MessageBox.Show("Please select the account where this money ACTUALLY was spent from or " +
            //        "arrived into.");
            //    isValid = false;
            //}

            //if (double.TryParse(txtAmount.Text, out double result))
            //{
            //    // I am hoping this is true if a double
            //    tran.Amount = double.Parse(txtAmount.Text);
            //}
            //else
            //{
            //    MessageBox.Show("So this should pop up if the amount box is not a number");
            //    isValid = false;
            //}

            

            //if (isValid==true)
            //{
            //    Global_Variable.transact = tran;
            //    frmSummary sum = new frmSummary();
            //    sum.Show();
            //}
            //else
            //{
            //    MessageBox.Show("so the isvalid turned out to be false");
            //    isValid = true;
            //}




            //if (needNew)
            //{
            //    // if you need a new list item... this format
            //    //List<int[]> objList = Global_Variable.tally_arr;
            //    objList.Add(new object[] { catID, srcID, amount });
            //    Global_Variable.tally_arr = objList;
            //}
            //else
            //{
                
            //    for (int i = 0; objList.Count > i; i++)
            //    {
            //        if ((int)(objList[i][0]) == tran.CategoryID && (int)(objList[i][1]) == tran.SourceID)
            //        {
            //            if (tran.IsCredit)
            //            {
            //                objList[i][3] = (int)(objList[i][3]) + tran.Amount;
            //            }
            //        }
            //    }
                
            //}


            





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
            //int[][] tally = new int[0][];
            //Global_Variable.tally_arr = tally;
            //ArrayList tally = new ArrayList();

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
    }
}
