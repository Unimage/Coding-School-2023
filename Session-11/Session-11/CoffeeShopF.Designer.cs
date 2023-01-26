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
            btnEmployeeRedirect = new Button();
            btnLoadLedger = new Button();
            btnTransactions = new Button();
            btnProduct = new Button();
            btnProductCategoryManagement = new Button();
            SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            btnEmployeeRedirect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEmployeeRedirect.BackColor = Color.Moccasin;
            btnEmployeeRedirect.Location = new Point(182, 476);
            btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            btnEmployeeRedirect.Size = new Size(163, 59);
            btnEmployeeRedirect.TabIndex = 0;
            btnEmployeeRedirect.Text = "Employee Management";
            btnEmployeeRedirect.UseVisualStyleBackColor = false;
            btnEmployeeRedirect.Click += btnEmployeeRedirect_Click;
            // 
            // btnLoadLedger
            // 
            btnLoadLedger.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoadLedger.BackColor = Color.SandyBrown;
            btnLoadLedger.Location = new Point(584, 479);
            btnLoadLedger.Name = "btnLoadLedger";
            btnLoadLedger.Size = new Size(163, 55);
            btnLoadLedger.TabIndex = 1;
            btnLoadLedger.Text = "Ledger";
            btnLoadLedger.UseVisualStyleBackColor = false;
            btnLoadLedger.Click += btnLoadLedger_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.SandyBrown;
            btnTransactions.Dock = DockStyle.Top;
            btnTransactions.Location = new Point(0, 0);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(774, 55);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProduct.BackColor = Color.Moccasin;
            btnProduct.Location = new Point(26, 475);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(150, 60);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Inventory Managment";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnProductCategoryManagement
            // 
            btnProductCategoryManagement.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProductCategoryManagement.BackColor = Color.Moccasin;
            btnProductCategoryManagement.Location = new Point(351, 478);
            btnProductCategoryManagement.Margin = new Padding(3, 2, 3, 2);
            btnProductCategoryManagement.Name = "btnProductCategoryManagement";
            btnProductCategoryManagement.Size = new Size(227, 55);
            btnProductCategoryManagement.TabIndex = 4;
            btnProductCategoryManagement.Text = "Product Category Management";
            btnProductCategoryManagement.UseVisualStyleBackColor = false;
            btnProductCategoryManagement.Click += btnProductCategoryManagement_Click;
            // 
            // CoffeeShopF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 546);
            Controls.Add(btnProductCategoryManagement);
            Controls.Add(btnProduct);
            Controls.Add(btnTransactions);
            Controls.Add(btnLoadLedger);
            Controls.Add(btnEmployeeRedirect);
            Name = "CoffeeShopF";
            Text = "CoffeeShop";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployeeRedirect;
        private Button btnLoadLedger;
        private Button btnTransactions;
        private Button btnProduct;
        private Button btnProductCategoryManagement;
    }
}