namespace BudgCalc.Presentation_Layer
{
    partial class frmAddBudget
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tbBudgetID = new System.Windows.Forms.TextBox();
            this.lblAddBudget = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.rbAddDebit = new System.Windows.Forms.RadioButton();
            this.rbAddCredit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddPurpose = new System.Windows.Forms.Label();
            this.lblAddBank = new System.Windows.Forms.Label();
            this.lblAddAmount = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tbBudgetID);
            this.gb1.Controls.Add(this.lblAddBudget);
            this.gb1.Location = new System.Drawing.Point(45, 23);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(346, 64);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            // 
            // tbBudgetID
            // 
            this.tbBudgetID.Location = new System.Drawing.Point(106, 28);
            this.tbBudgetID.Name = "tbBudgetID";
            this.tbBudgetID.Size = new System.Drawing.Size(197, 20);
            this.tbBudgetID.TabIndex = 1;
            // 
            // lblAddBudget
            // 
            this.lblAddBudget.AutoSize = true;
            this.lblAddBudget.Location = new System.Drawing.Point(36, 28);
            this.lblAddBudget.Name = "lblAddBudget";
            this.lblAddBudget.Size = new System.Drawing.Size(61, 13);
            this.lblAddBudget.TabIndex = 0;
            this.lblAddBudget.Text = "Budget ID: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPurpose);
            this.groupBox2.Controls.Add(this.tbAmount);
            this.groupBox2.Controls.Add(this.tbCat);
            this.groupBox2.Controls.Add(this.cbBank);
            this.groupBox2.Controls.Add(this.rbAddDebit);
            this.groupBox2.Controls.Add(this.rbAddCredit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblAddPurpose);
            this.groupBox2.Controls.Add(this.lblAddBank);
            this.groupBox2.Controls.Add(this.lblAddAmount);
            this.groupBox2.Controls.Add(this.lblAddCategory);
            this.groupBox2.Location = new System.Drawing.Point(45, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tbPurpose
            // 
            this.tbPurpose.Location = new System.Drawing.Point(106, 94);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(197, 20);
            this.tbPurpose.TabIndex = 10;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(106, 42);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(197, 20);
            this.tbAmount.TabIndex = 9;
            // 
            // tbCat
            // 
            this.tbCat.Location = new System.Drawing.Point(106, 16);
            this.tbCat.Name = "tbCat";
            this.tbCat.Size = new System.Drawing.Size(197, 20);
            this.tbCat.TabIndex = 8;
            // 
            // cbBank
            // 
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Location = new System.Drawing.Point(106, 67);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(197, 21);
            this.cbBank.TabIndex = 7;
            // 
            // rbAddDebit
            // 
            this.rbAddDebit.AutoSize = true;
            this.rbAddDebit.Location = new System.Drawing.Point(233, 134);
            this.rbAddDebit.Name = "rbAddDebit";
            this.rbAddDebit.Size = new System.Drawing.Size(70, 17);
            this.rbAddDebit.TabIndex = 6;
            this.rbAddDebit.TabStop = true;
            this.rbAddDebit.Text = "Spending";
            this.rbAddDebit.UseVisualStyleBackColor = true;
            // 
            // rbAddCredit
            // 
            this.rbAddCredit.AutoSize = true;
            this.rbAddCredit.Location = new System.Drawing.Point(106, 134);
            this.rbAddCredit.Name = "rbAddCredit";
            this.rbAddCredit.Size = new System.Drawing.Size(61, 17);
            this.rbAddCredit.TabIndex = 5;
            this.rbAddCredit.TabStop = true;
            this.rbAddCredit.Text = "Earning";
            this.rbAddCredit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // lblAddPurpose
            // 
            this.lblAddPurpose.AutoSize = true;
            this.lblAddPurpose.Location = new System.Drawing.Point(36, 101);
            this.lblAddPurpose.Name = "lblAddPurpose";
            this.lblAddPurpose.Size = new System.Drawing.Size(46, 13);
            this.lblAddPurpose.TabIndex = 3;
            this.lblAddPurpose.Text = "Purpose";
            // 
            // lblAddBank
            // 
            this.lblAddBank.AutoSize = true;
            this.lblAddBank.Location = new System.Drawing.Point(36, 75);
            this.lblAddBank.Name = "lblAddBank";
            this.lblAddBank.Size = new System.Drawing.Size(32, 13);
            this.lblAddBank.TabIndex = 2;
            this.lblAddBank.Text = "Bank";
            // 
            // lblAddAmount
            // 
            this.lblAddAmount.AutoSize = true;
            this.lblAddAmount.Location = new System.Drawing.Point(36, 49);
            this.lblAddAmount.Name = "lblAddAmount";
            this.lblAddAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAddAmount.TabIndex = 1;
            this.lblAddAmount.Text = "Amount";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(36, 23);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(49, 13);
            this.lblAddCategory.TabIndex = 0;
            this.lblAddCategory.Text = "Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(45, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 37);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb1);
            this.Name = "frmAddBudget";
            this.Text = "Add Budget";
            this.Load += new System.EventHandler(this.frmAddBudget_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lblAddBudget;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAddPurpose;
        private System.Windows.Forms.Label lblAddBank;
        private System.Windows.Forms.Label lblAddAmount;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAddDebit;
        private System.Windows.Forms.RadioButton rbAddCredit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.TextBox tbBudgetID;
    }
}