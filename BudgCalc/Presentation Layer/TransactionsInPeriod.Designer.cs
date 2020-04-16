namespace BudgCalc.Presentation_Layer
{
    partial class frmTransPeriod
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTransCancel = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnSearchTrans = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(13, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 239);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTransCancel
            // 
            this.btnTransCancel.Location = new System.Drawing.Point(477, 285);
            this.btnTransCancel.Name = "btnTransCancel";
            this.btnTransCancel.Size = new System.Drawing.Size(136, 23);
            this.btnTransCancel.TabIndex = 2;
            this.btnTransCancel.Text = "Cancel";
            this.btnTransCancel.UseVisualStyleBackColor = true;
            this.btnTransCancel.Click += new System.EventHandler(this.btnTransCancel_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(188, 285);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteTransaction.TabIndex = 3;
            this.btnDeleteTransaction.Text = "Delete";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // btnSearchTrans
            // 
            this.btnSearchTrans.Location = new System.Drawing.Point(344, 285);
            this.btnSearchTrans.Name = "btnSearchTrans";
            this.btnSearchTrans.Size = new System.Drawing.Size(113, 23);
            this.btnSearchTrans.TabIndex = 4;
            this.btnSearchTrans.Text = "Search";
            this.btnSearchTrans.UseVisualStyleBackColor = true;
            this.btnSearchTrans.Click += new System.EventHandler(this.btnSearchTrans_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Transaction ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "date";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Source";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Credit or Debit";
            // 
            // frmTransPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.btnSearchTrans);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnTransCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listView1);
            this.Name = "frmTransPeriod";
            this.Text = "TransactionsInPeriod";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTransCancel;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnSearchTrans;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}