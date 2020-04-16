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
    public partial class frmAddSource : Form
    {
        public frmAddSource()
        {
            InitializeComponent();
        }

        private void AddSource_Load(object sender, EventArgs e)
        {
            // Fill Combo boxes with possible data for the user to select.
            FillComboBoxes();

            // If Update, make appropriate adjustments and prefill source data.
            if (Global_Variable.sourceID > 0) // TODO in budget, when it is clicked, add the global
            {
                this.Text = "Update Source";
                btnSourceAdd.Text = "&Update";
                // user cannot change only view
                txtSourceID.Enabled = false;
                FillSourceFieldsWithCurrent();

            }
            else // if add new budget item
            {
                // inform customer of ID process.
                this.Text = "Add Source";
                btnSourceAdd.Text = "Add";

                // makes the box disappear
                txtSourceID.Visible = false;
                lblSource.Text = "Source ID generated automatically.";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void FillComboBoxes()
        {
            // TODO
        }

        private void FillSourceFieldsWithCurrent()
        {
            // TODO add new data into db
        }
    }
}
