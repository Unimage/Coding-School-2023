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
            this.SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            this.btnEmployeeRedirect.Location = new System.Drawing.Point(211, 61);
            this.btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            this.btnEmployeeRedirect.Size = new System.Drawing.Size(163, 79);
            this.btnEmployeeRedirect.TabIndex = 0;
            this.btnEmployeeRedirect.Text = "Employee Management";
            this.btnEmployeeRedirect.UseVisualStyleBackColor = true;
            this.btnEmployeeRedirect.Click += new System.EventHandler(this.btnEmployeeRedirect_Click);
            // 
            // btnLoadLedger
            // 
            this.btnLoadLedger.Location = new System.Drawing.Point(211, 474);
            this.btnLoadLedger.Name = "btnLoadLedger";
            this.btnLoadLedger.Size = new System.Drawing.Size(163, 75);
            this.btnLoadLedger.TabIndex = 1;
            this.btnLoadLedger.Text = "Ledger";
            this.btnLoadLedger.UseVisualStyleBackColor = true;
            this.btnLoadLedger.Click += new System.EventHandler(this.btnLoadLedger_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(885, 275);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(212, 88);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(643, 95);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(171, 80);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Inventory Managment";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // CoffeeShopF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 728);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnLoadLedger);
            this.Controls.Add(this.btnEmployeeRedirect);
            this.Name = "CoffeeShopF";
            this.Text = "CoffeeShop";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEmployeeRedirect;
        private Button btnLoadLedger;
        private Button btnTransactions;
        private Button btnProduct;
    }
}