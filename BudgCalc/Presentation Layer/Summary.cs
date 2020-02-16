using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BudgCalc.Presentation_Layer
{
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            //lblGV.Text = Global_Variable.transact.Amount.ToString() +
            //    " " + Global_Variable.transact.CategoryID.ToString() +
            //    " " + Global_Variable.transact.IsCredit.ToString() +
            //    " " + Global_Variable.transact.SourceID.ToString();
            //    //Global_Variable.selectedAmount.ToString();

            if (Global_Variable.tally_arr.Count > 0)
            {
                lblGV.Text = "the tally list is: " + Global_Variable.tally_arr[0][0].ToString()
                    + ", " + Global_Variable.tally_arr[0][1].ToString() + ", "
                    + Global_Variable.tally_arr[0][2].ToString();
            }
            else
            {
                Console.Write("nothing in the global array");
                Console.WriteLine();
            }

            //if (Global_Variable.transact.CategoryID!=0)
            //{
            //    lblGV.Text = Global_Variable.transact.CategoryID.ToString();
            //}
            //else
            //{
            //    Console.Write("nothing in the global array");
            //    Console.WriteLine();
            //}


        }
    }
}
