namespace FuelStation.Win {
    partial class HomeF {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomer.Location = new System.Drawing.Point(149, 188);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(191, 77);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer Management";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Visible = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnItem
            // 
            this.btnItem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItem.Location = new System.Drawing.Point(363, 188);
            this.btnItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(191, 77);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "Item Management";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Visible = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransactions.Location = new System.Drawing.Point(580, 188);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(191, 77);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(396, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operatons";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(363, 387);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(191, 77);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HomeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeF";
            this.Text = "HomeF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCustomer;
        private Button btnItem;
        private Button btnTransactions;
        private Label label1;
        private Button btnLogout;
    }
}