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
    }
}
