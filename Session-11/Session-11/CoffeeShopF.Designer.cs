﻿namespace Session_11
{
    partial class CoffeeShopF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmployeeRedirect = new System.Windows.Forms.Button();
            this.btnLoadLedger = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnProductCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            this.btnEmployeeRedirect.Location = new System.Drawing.Point(241, 81);
            this.btnEmployeeRedirect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            this.btnEmployeeRedirect.Size = new System.Drawing.Size(186, 105);
            this.btnEmployeeRedirect.TabIndex = 0;
            this.btnEmployeeRedirect.Text = "Employee Management";
            this.btnEmployeeRedirect.UseVisualStyleBackColor = true;
            this.btnEmployeeRedirect.Click += new System.EventHandler(this.btnEmployeeRedirect_Click);
            // 
            // btnLoadLedger
            // 
            this.btnLoadLedger.Location = new System.Drawing.Point(241, 632);
            this.btnLoadLedger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadLedger.Name = "btnLoadLedger";
            this.btnLoadLedger.Size = new System.Drawing.Size(186, 100);
            this.btnLoadLedger.TabIndex = 1;
            this.btnLoadLedger.Text = "Ledger";
            this.btnLoadLedger.UseVisualStyleBackColor = true;
            this.btnLoadLedger.Click += new System.EventHandler(this.btnLoadLedger_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(1011, 367);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(242, 117);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnProductCategories
            // 
            this.btnProductCategories.Location = new System.Drawing.Point(222, 315);
            this.btnProductCategories.Name = "btnProductCategories";
            this.btnProductCategories.Size = new System.Drawing.Size(247, 123);
            this.btnProductCategories.TabIndex = 3;
            this.btnProductCategories.Text = "Product Categories Management";
            this.btnProductCategories.UseVisualStyleBackColor = true;
            this.btnProductCategories.Click += new System.EventHandler(this.btnProductCategories_Click);
            // 
            // CoffeeShopF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 971);
            this.Controls.Add(this.btnProductCategories);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnLoadLedger);
            this.Controls.Add(this.btnEmployeeRedirect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CoffeeShopF";
            this.Text = "CoffeeShop";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEmployeeRedirect;
        private Button btnLoadLedger;
        private Button btnTransactions;
        private Button btnProductCategories;
    }
}