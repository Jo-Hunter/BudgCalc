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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddBudget = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddAmount = new System.Windows.Forms.Label();
            this.lblAddBank = new System.Windows.Forms.Label();
            this.lblAddPurpose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAddCredit = new System.Windows.Forms.RadioButton();
            this.rbAddDebit = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddBudget);
            this.groupBox1.Location = new System.Drawing.Point(45, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblAddBudget
            // 
            this.lblAddBudget.AutoSize = true;
            this.lblAddBudget.Location = new System.Drawing.Point(36, 28);
            this.lblAddBudget.Name = "lblAddBudget";
            this.lblAddBudget.Size = new System.Drawing.Size(143, 13);
            this.lblAddBudget.TabIndex = 0;
            this.lblAddBudget.Text = "will work out ID automatically";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAddDebit);
            this.groupBox2.Controls.Add(this.rbAddCredit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblAddPurpose);
            this.groupBox2.Controls.Add(this.lblAddBank);
            this.groupBox2.Controls.Add(this.lblAddAmount);
            this.groupBox2.Controls.Add(this.lblAddCategory);
            this.groupBox2.Location = new System.Drawing.Point(45, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(7, 20);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(49, 13);
            this.lblAddCategory.TabIndex = 0;
            this.lblAddCategory.Text = "Category";
            // 
            // lblAddAmount
            // 
            this.lblAddAmount.AutoSize = true;
            this.lblAddAmount.Location = new System.Drawing.Point(7, 46);
            this.lblAddAmount.Name = "lblAddAmount";
            this.lblAddAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAddAmount.TabIndex = 1;
            this.lblAddAmount.Text = "Amount";
            // 
            // lblAddBank
            // 
            this.lblAddBank.AutoSize = true;
            this.lblAddBank.Location = new System.Drawing.Point(7, 72);
            this.lblAddBank.Name = "lblAddBank";
            this.lblAddBank.Size = new System.Drawing.Size(32, 13);
            this.lblAddBank.TabIndex = 2;
            this.lblAddBank.Text = "Bank";
            // 
            // lblAddPurpose
            // 
            this.lblAddPurpose.AutoSize = true;
            this.lblAddPurpose.Location = new System.Drawing.Point(7, 98);
            this.lblAddPurpose.Name = "lblAddPurpose";
            this.lblAddPurpose.Size = new System.Drawing.Size(46, 13);
            this.lblAddPurpose.TabIndex = 3;
            this.lblAddPurpose.Text = "Purpose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // rbAddCredit
            // 
            this.rbAddCredit.AutoSize = true;
            this.rbAddCredit.Location = new System.Drawing.Point(13, 124);
            this.rbAddCredit.Name = "rbAddCredit";
            this.rbAddCredit.Size = new System.Drawing.Size(61, 17);
            this.rbAddCredit.TabIndex = 5;
            this.rbAddCredit.TabStop = true;
            this.rbAddCredit.Text = "Earning";
            this.rbAddCredit.UseVisualStyleBackColor = true;
            // 
            // rbAddDebit
            // 
            this.rbAddDebit.AutoSize = true;
            this.rbAddDebit.Location = new System.Drawing.Point(94, 124);
            this.rbAddDebit.Name = "rbAddDebit";
            this.rbAddDebit.Size = new System.Drawing.Size(70, 17);
            this.rbAddDebit.TabIndex = 6;
            this.rbAddDebit.TabStop = true;
            this.rbAddDebit.Text = "Spending";
            this.rbAddDebit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(45, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 37);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddBudget";
            this.Text = "Add Budget";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}