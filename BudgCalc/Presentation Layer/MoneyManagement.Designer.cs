namespace BudgCalc.Presentation_Layer
{
    partial class frmManager
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
            this.lvBudget = new System.Windows.Forms.ListView();
            this.lbtlTotalBudget = new System.Windows.Forms.Label();
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnCancelM = new System.Windows.Forms.Button();
            this.btnDeleteM = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankMoneyStartsFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBudget
            // 
            this.lvBudget.Location = new System.Drawing.Point(15, 49);
            this.lvBudget.Name = "lvBudget";
            this.lvBudget.Size = new System.Drawing.Size(517, 285);
            this.lvBudget.TabIndex = 0;
            this.lvBudget.UseCompatibleStateImageBehavior = false;
            this.lvBudget.View = System.Windows.Forms.View.Details;
            // 
            // lbtlTotalBudget
            // 
            this.lbtlTotalBudget.AutoSize = true;
            this.lbtlTotalBudget.Location = new System.Drawing.Point(15, 24);
            this.lbtlTotalBudget.Name = "lbtlTotalBudget";
            this.lbtlTotalBudget.Size = new System.Drawing.Size(90, 13);
            this.lbtlTotalBudget.TabIndex = 1;
            this.lbtlTotalBudget.Text = "Budget Total is: $";
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(15, 357);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(148, 23);
            this.btnAddM.TabIndex = 2;
            this.btnAddM.Text = "Edit Period";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnCancelM
            // 
            this.btnCancelM.Location = new System.Drawing.Point(369, 357);
            this.btnCancelM.Name = "btnCancelM";
            this.btnCancelM.Size = new System.Drawing.Size(161, 23);
            this.btnCancelM.TabIndex = 3;
            this.btnCancelM.Text = "Cancel";
            this.btnCancelM.UseVisualStyleBackColor = true;
            this.btnCancelM.Click += new System.EventHandler(this.btnCancelM_Click);
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.Location = new System.Drawing.Point(198, 357);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteM.TabIndex = 4;
            this.btnDeleteM.Text = "Delete";
            this.btnDeleteM.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankingDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bankingDetailsToolStripMenuItem
            // 
            this.bankingDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankMoneyStartsFromToolStripMenuItem,
            this.budgetCategoriesToolStripMenuItem});
            this.bankingDetailsToolStripMenuItem.Name = "bankingDetailsToolStripMenuItem";
            this.bankingDetailsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.bankingDetailsToolStripMenuItem.Text = "Banking Details";
            // 
            // bankMoneyStartsFromToolStripMenuItem
            // 
            this.bankMoneyStartsFromToolStripMenuItem.Name = "bankMoneyStartsFromToolStripMenuItem";
            this.bankMoneyStartsFromToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.bankMoneyStartsFromToolStripMenuItem.Text = "Money Sources";
            this.bankMoneyStartsFromToolStripMenuItem.Click += new System.EventHandler(this.bankMoneyStartsFromToolStripMenuItem_Click);
            // 
            // budgetCategoriesToolStripMenuItem
            // 
            this.budgetCategoriesToolStripMenuItem.Name = "budgetCategoriesToolStripMenuItem";
            this.budgetCategoriesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.budgetCategoriesToolStripMenuItem.Text = "Budget categories";
            this.budgetCategoriesToolStripMenuItem.Click += new System.EventHandler(this.budgetCategoriesToolStripMenuItem_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 399);
            this.Controls.Add(this.btnDeleteM);
            this.Controls.Add(this.btnCancelM);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.lbtlTotalBudget);
            this.Controls.Add(this.lvBudget);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManager";
            this.Text = "MoneyManagement";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvBudget;
        private System.Windows.Forms.Label lbtlTotalBudget;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.Button btnCancelM;
        private System.Windows.Forms.Button btnDeleteM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bankingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankMoneyStartsFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetCategoriesToolStripMenuItem;
    }
}