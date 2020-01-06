namespace BudgCalc.Presentation_Layer
{
    partial class frmBudget
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankMoneyStartsFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBudget
            // 
            this.lvBudget.Location = new System.Drawing.Point(13, 57);
            this.lvBudget.Name = "lvBudget";
            this.lvBudget.Size = new System.Drawing.Size(517, 280);
            this.lvBudget.TabIndex = 0;
            this.lvBudget.UseCompatibleStateImageBehavior = false;
            // 
            // lbtlTotalBudget
            // 
            this.lbtlTotalBudget.AutoSize = true;
            this.lbtlTotalBudget.Location = new System.Drawing.Point(12, 24);
            this.lbtlTotalBudget.Name = "lbtlTotalBudget";
            this.lbtlTotalBudget.Size = new System.Drawing.Size(90, 13);
            this.lbtlTotalBudget.TabIndex = 1;
            this.lbtlTotalBudget.Text = "Budget Total is: $";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(369, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.bankToolStripMenuItem,
            this.bankMoneyStartsFromToolStripMenuItem});
            this.bankingDetailsToolStripMenuItem.Name = "bankingDetailsToolStripMenuItem";
            this.bankingDetailsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.bankingDetailsToolStripMenuItem.Text = "Banking Details";
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bankToolStripMenuItem.Text = "Bank";
            // 
            // bankMoneyStartsFromToolStripMenuItem
            // 
            this.bankMoneyStartsFromToolStripMenuItem.Name = "bankMoneyStartsFromToolStripMenuItem";
            this.bankMoneyStartsFromToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bankMoneyStartsFromToolStripMenuItem.Text = "Money Held in";
            this.bankMoneyStartsFromToolStripMenuItem.Click += new System.EventHandler(this.bankMoneyStartsFromToolStripMenuItem_Click);
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 399);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbtlTotalBudget);
            this.Controls.Add(this.lvBudget);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBudget";
            this.Text = "MoneyManagement";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvBudget;
        private System.Windows.Forms.Label lbtlTotalBudget;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bankingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankMoneyStartsFromToolStripMenuItem;
    }
}