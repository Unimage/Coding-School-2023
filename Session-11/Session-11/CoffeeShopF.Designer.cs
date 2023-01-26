namespace Session_11
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnProductCategoryManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            this.btnEmployeeRedirect.BackColor = System.Drawing.Color.Moccasin;
            this.btnEmployeeRedirect.Location = new System.Drawing.Point(168, 46);
            this.btnEmployeeRedirect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            this.btnEmployeeRedirect.Size = new System.Drawing.Size(186, 105);
            this.btnEmployeeRedirect.TabIndex = 0;
            this.btnEmployeeRedirect.Text = "Employee Management";
            this.btnEmployeeRedirect.UseVisualStyleBackColor = false;
            this.btnEmployeeRedirect.Click += new System.EventHandler(this.btnEmployeeRedirect_Click);
            // 
            // btnLoadLedger
            // 
            this.btnLoadLedger.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoadLedger.Location = new System.Drawing.Point(803, 408);
            this.btnLoadLedger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadLedger.Name = "btnLoadLedger";
            this.btnLoadLedger.Size = new System.Drawing.Size(186, 100);
            this.btnLoadLedger.TabIndex = 1;
            this.btnLoadLedger.Text = "Ledger";
            this.btnLoadLedger.UseVisualStyleBackColor = false;
            this.btnLoadLedger.Click += new System.EventHandler(this.btnLoadLedger_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTransactions.Location = new System.Drawing.Point(766, 129);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(242, 73);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Moccasin;
            this.btnProduct.Location = new System.Drawing.Point(168, 408);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(171, 80);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Inventory Managment";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProductCategoryManagement
            // 
            this.btnProductCategoryManagement.BackColor = System.Drawing.Color.Moccasin;
            this.btnProductCategoryManagement.Location = new System.Drawing.Point(168, 236);
            this.btnProductCategoryManagement.Name = "btnProductCategoryManagement";
            this.btnProductCategoryManagement.Size = new System.Drawing.Size(259, 73);
            this.btnProductCategoryManagement.TabIndex = 4;
            this.btnProductCategoryManagement.Text = "Product Category Management";
            this.btnProductCategoryManagement.UseVisualStyleBackColor = false;
            this.btnProductCategoryManagement.Click += new System.EventHandler(this.btnProductCategoryManagement_Click);
            // 
            // CoffeeShopF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 728);
            this.Controls.Add(this.btnProductCategoryManagement);
            this.Controls.Add(this.btnProduct);
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
        private Button btnProduct;
        private Button btnProductCategoryManagement;
    }
}