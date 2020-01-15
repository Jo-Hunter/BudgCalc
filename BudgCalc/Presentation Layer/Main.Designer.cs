namespace BudgCalc
{
    partial class frmMain
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSpendAccount = new System.Windows.Forms.Label();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.rbSpent = new System.Windows.Forms.RadioButton();
            this.rbEarned = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(12, 73);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 35);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Budget Category:";
            // 
            // lblSpendAccount
            // 
            this.lblSpendAccount.AutoSize = true;
            this.lblSpendAccount.Location = new System.Drawing.Point(223, 35);
            this.lblSpendAccount.Name = "lblSpendAccount";
            this.lblSpendAccount.Size = new System.Drawing.Size(104, 13);
            this.lblSpendAccount.TabIndex = 3;
            this.lblSpendAccount.Text = "Spent from Account:";
            this.lblSpendAccount.Click += new System.EventHandler(this.lblSpendAccount_Click);
            // 
            // cbAccount
            // 
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(226, 73);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(121, 21);
            this.cbAccount.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(370, 35);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(61, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount ($):";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(373, 74);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(490, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Transaction";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.Location = new System.Drawing.Point(218, 157);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(121, 23);
            this.btnBudget.TabIndex = 7;
            this.btnBudget.Text = "Adjust budget";
            this.btnBudget.UseVisualStyleBackColor = true;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(80, 157);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(118, 23);
            this.btnPeriod.TabIndex = 8;
            this.btnPeriod.Text = "End Period";
            this.btnPeriod.UseVisualStyleBackColor = true;
            // 
            // rbSpent
            // 
            this.rbSpent.AutoSize = true;
            this.rbSpent.Location = new System.Drawing.Point(153, 67);
            this.rbSpent.Name = "rbSpent";
            this.rbSpent.Size = new System.Drawing.Size(53, 17);
            this.rbSpent.TabIndex = 10;
            this.rbSpent.TabStop = true;
            this.rbSpent.Text = "Spent";
            this.rbSpent.UseVisualStyleBackColor = true;
            // 
            // rbEarned
            // 
            this.rbEarned.AutoSize = true;
            this.rbEarned.Location = new System.Drawing.Point(153, 90);
            this.rbEarned.Name = "rbEarned";
            this.rbEarned.Size = new System.Drawing.Size(59, 17);
            this.rbEarned.TabIndex = 11;
            this.rbEarned.TabStop = true;
            this.rbEarned.Text = "Earned";
            this.rbEarned.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 261);
            this.Controls.Add(this.rbEarned);
            this.Controls.Add(this.rbSpent);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSpendAccount);
            this.Controls.Add(this.cbAccount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Name = "frmMain";
            this.Text = "Budget Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSpendAccount;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.RadioButton rbSpent;
        private System.Windows.Forms.RadioButton rbEarned;
    }
}

