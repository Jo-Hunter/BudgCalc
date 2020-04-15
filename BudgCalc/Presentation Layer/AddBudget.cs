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
    public partial class frmAddBudget : Form
    {
        public frmAddBudget()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddBudget_Load(object sender, EventArgs e)
        {
            // work out if add or update
            // if add, get the sources
            // if update, get all the fields
        }
    }
}
