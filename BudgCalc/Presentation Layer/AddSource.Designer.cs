namespace BudgCalc.Presentation_Layer
{
    partial class frmAddSource
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSourceAdd = new System.Windows.Forms.Button();
            this.btnSourceCancel = new System.Windows.Forms.Button();
            this.lblSourceID = new System.Windows.Forms.Label();
            this.txtSourceID = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSourceID);
            this.groupBox1.Controls.Add(this.lblSourceID);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSource);
            this.groupBox2.Controls.Add(this.lblSource);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(27, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSourceCancel);
            this.groupBox4.Controls.Add(this.btnSourceAdd);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(27, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 66);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 81);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // btnSourceAdd
            // 
            this.btnSourceAdd.Enabled = false;
            this.btnSourceAdd.Location = new System.Drawing.Point(7, 19);
            this.btnSourceAdd.Name = "btnSourceAdd";
            this.btnSourceAdd.Size = new System.Drawing.Size(124, 23);
            this.btnSourceAdd.TabIndex = 3;
            this.btnSourceAdd.Text = "Add";
            this.btnSourceAdd.UseVisualStyleBackColor = true;
            this.btnSourceAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSourceCancel
            // 
            this.btnSourceCancel.Location = new System.Drawing.Point(167, 19);
            this.btnSourceCancel.Name = "btnSourceCancel";
            this.btnSourceCancel.Size = new System.Drawing.Size(124, 23);
            this.btnSourceCancel.TabIndex = 4;
            this.btnSourceCancel.Text = "Cancel";
            this.btnSourceCancel.UseVisualStyleBackColor = true;
            this.btnSourceCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSourceID
            // 
            this.lblSourceID.AutoSize = true;
            this.lblSourceID.Location = new System.Drawing.Point(7, 27);
            this.lblSourceID.Name = "lblSourceID";
            this.lblSourceID.Size = new System.Drawing.Size(55, 13);
            this.lblSourceID.TabIndex = 0;
            this.lblSourceID.Text = "SourceID:";
            // 
            // txtSourceID
            // 
            this.txtSourceID.Location = new System.Drawing.Point(97, 20);
            this.txtSourceID.Name = "txtSourceID";
            this.txtSourceID.Size = new System.Drawing.Size(194, 20);
            this.txtSourceID.TabIndex = 1;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(7, 60);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(84, 13);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "Bank or Source:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(97, 53);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(194, 20);
            this.txtSource.TabIndex = 2;
            // 
            // frmAddSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 305);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddSource";
            this.Text = "Add Source";
            this.Load += new System.EventHandler(this.AddSource_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSourceCancel;
        private System.Windows.Forms.Button btnSourceAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSourceID;
        private System.Windows.Forms.Label lblSourceID;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblSource;
    }
}