namespace BudgCalc.Presentation_Layer
{
    partial class frmSearchTrans
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnSearchCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPeriodSelect = new System.Windows.Forms.ComboBox();
            this.lblPeriodSelect = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEndDateSelect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(222, 29);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(96, 23);
            this.btnCurrent.TabIndex = 1;
            this.btnCurrent.Text = "Current Period";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.Location = new System.Drawing.Point(304, 19);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(161, 23);
            this.btnSearchCancel.TabIndex = 2;
            this.btnSearchCancel.Text = "Cancel";
            this.btnSearchCancel.UseVisualStyleBackColor = true;
            this.btnSearchCancel.Click += new System.EventHandler(this.btnSearchCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchCancel);
            this.groupBox1.Location = new System.Drawing.Point(13, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.btnCurrent);
            this.groupBox2.Controls.Add(this.cbPeriodSelect);
            this.groupBox2.Controls.Add(this.lblPeriodSelect);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // cbPeriodSelect
            // 
            this.cbPeriodSelect.FormattingEnabled = true;
            this.cbPeriodSelect.Location = new System.Drawing.Point(149, 30);
            this.cbPeriodSelect.Name = "cbPeriodSelect";
            this.cbPeriodSelect.Size = new System.Drawing.Size(33, 21);
            this.cbPeriodSelect.TabIndex = 1;
            // 
            // lblPeriodSelect
            // 
            this.lblPeriodSelect.AutoSize = true;
            this.lblPeriodSelect.Location = new System.Drawing.Point(44, 30);
            this.lblPeriodSelect.Name = "lblPeriodSelect";
            this.lblPeriodSelect.Size = new System.Drawing.Size(73, 13);
            this.lblPeriodSelect.TabIndex = 0;
            this.lblPeriodSelect.Text = "Select Period:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEnd);
            this.groupBox3.Controls.Add(this.dtpStart);
            this.groupBox3.Controls.Add(this.lblEndDateSelect);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 118);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // lblEndDateSelect
            // 
            this.lblEndDateSelect.AutoSize = true;
            this.lblEndDateSelect.Location = new System.Drawing.Point(46, 78);
            this.lblEndDateSelect.Name = "lblEndDateSelect";
            this.lblEndDateSelect.Size = new System.Drawing.Size(88, 13);
            this.lblEndDateSelect.TabIndex = 1;
            this.lblEndDateSelect.Text = "Select End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Start Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(148, 34);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(306, 20);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(148, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(306, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(359, 29);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(96, 23);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All Transactions";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // frmSearchTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchTrans";
            this.Text = "SearchTransactions";
            this.Load += new System.EventHandler(this.frmSearchTrans_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnSearchCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPeriodSelect;
        private System.Windows.Forms.Label lblPeriodSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEndDateSelect;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnAll;
    }
}