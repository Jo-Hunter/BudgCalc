﻿namespace BudgCalc.Presentation_Layer
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "filter the trans you want";
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(59, 59);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(161, 23);
            this.btnCurrent.TabIndex = 1;
            this.btnCurrent.Text = "Current Period";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.Location = new System.Drawing.Point(59, 188);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(161, 23);
            this.btnSearchCancel.TabIndex = 2;
            this.btnSearchCancel.Text = "Cancel";
            this.btnSearchCancel.UseVisualStyleBackColor = true;
            this.btnSearchCancel.Click += new System.EventHandler(this.btnSearchCancel_Click);
            // 
            // frmSearchTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSearchCancel);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchTrans";
            this.Text = "SearchTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnSearchCancel;
    }
}