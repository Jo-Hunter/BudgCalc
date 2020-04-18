namespace BudgCalc.Presentation_Layer
{
    partial class frmSource
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
            this.lvSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSourceAdd = new System.Windows.Forms.Button();
            this.btnSourceDelete = new System.Windows.Forms.Button();
            this.btnSourceCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "These sources should include ANY source including where money goes into and where" +
    " money departs from";
            // 
            // lvSource
            // 
            this.lvSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSource.Location = new System.Drawing.Point(12, 29);
            this.lvSource.Name = "lvSource";
            this.lvSource.Size = new System.Drawing.Size(597, 232);
            this.lvSource.TabIndex = 1;
            this.lvSource.UseCompatibleStateImageBehavior = false;
            this.lvSource.View = System.Windows.Forms.View.Details;
            this.lvSource.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSource_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "source";
            this.columnHeader2.Width = 130;
            // 
            // btnSourceAdd
            // 
            this.btnSourceAdd.Location = new System.Drawing.Point(16, 283);
            this.btnSourceAdd.Name = "btnSourceAdd";
            this.btnSourceAdd.Size = new System.Drawing.Size(156, 23);
            this.btnSourceAdd.TabIndex = 2;
            this.btnSourceAdd.Text = "Add";
            this.btnSourceAdd.UseVisualStyleBackColor = true;
            this.btnSourceAdd.Click += new System.EventHandler(this.btnSourceAdd_Click);
            // 
            // btnSourceDelete
            // 
            this.btnSourceDelete.Location = new System.Drawing.Point(214, 283);
            this.btnSourceDelete.Name = "btnSourceDelete";
            this.btnSourceDelete.Size = new System.Drawing.Size(161, 23);
            this.btnSourceDelete.TabIndex = 3;
            this.btnSourceDelete.Text = "Delete";
            this.btnSourceDelete.UseVisualStyleBackColor = true;
            // 
            // btnSourceCancel
            // 
            this.btnSourceCancel.Location = new System.Drawing.Point(466, 283);
            this.btnSourceCancel.Name = "btnSourceCancel";
            this.btnSourceCancel.Size = new System.Drawing.Size(143, 23);
            this.btnSourceCancel.TabIndex = 4;
            this.btnSourceCancel.Text = "Cancel";
            this.btnSourceCancel.UseVisualStyleBackColor = true;
            this.btnSourceCancel.Click += new System.EventHandler(this.btnSourceCancel_Click);
            // 
            // frmSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 318);
            this.Controls.Add(this.btnSourceCancel);
            this.Controls.Add(this.btnSourceDelete);
            this.Controls.Add(this.btnSourceAdd);
            this.Controls.Add(this.lvSource);
            this.Controls.Add(this.label1);
            this.Name = "frmSource";
            this.Text = "Source";
            this.Load += new System.EventHandler(this.frmSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSourceAdd;
        private System.Windows.Forms.Button btnSourceDelete;
        private System.Windows.Forms.Button btnSourceCancel;
    }
}