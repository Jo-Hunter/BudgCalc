namespace BudgCalc.Presentation_Layer
{
    partial class frmSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblGV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(48, 39);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(458, 13);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "This is where you can see the ongoing amount that should pop up every time you hi" +
    "t transaction";
            // 
            // lblGV
            // 
            this.lblGV.AutoSize = true;
            this.lblGV.Location = new System.Drawing.Point(51, 92);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(0, 13);
            this.lblGV.TabIndex = 1;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 318);
            this.Controls.Add(this.lblGV);
            this.Controls.Add(this.lblInstruction);
            this.Name = "frmSummary";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.frmSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblGV;
    }
}