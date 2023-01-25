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
            SuspendLayout();
            // 
            // btnEmployeeRedirect
            // 
            btnEmployeeRedirect.Location = new Point(211, 61);
            btnEmployeeRedirect.Name = "btnEmployeeRedirect";
            btnEmployeeRedirect.Size = new Size(163, 79);
            btnEmployeeRedirect.TabIndex = 0;
            btnEmployeeRedirect.Text = "Employee Management";
            btnEmployeeRedirect.UseVisualStyleBackColor = true;
            btnEmployeeRedirect.Click += btnEmployeeRedirect_Click;
            // 
            // btnLoadLedger
            // 
            btnLoadLedger.Location = new Point(211, 474);
            btnLoadLedger.Name = "btnLoadLedger";
            btnLoadLedger.Size = new Size(163, 75);
            btnLoadLedger.TabIndex = 1;
            btnLoadLedger.Text = "Ledger";
            btnLoadLedger.UseVisualStyleBackColor = true;
            btnLoadLedger.Click += btnLoadLedger_Click;
            // 
            // CoffeeShopF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 728);
            Controls.Add(btnLoadLedger);
            Controls.Add(btnEmployeeRedirect);
            Name = "CoffeeShopF";
            Text = "CoffeeShop";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployeeRedirect;
        private Button btnLoadLedger;
    }
}