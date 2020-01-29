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
            lblGV.Text = Global_Variable.transact.Amount.ToString();
                //Global_Variable.selectedAmount.ToString();
               
        }
    }
}
