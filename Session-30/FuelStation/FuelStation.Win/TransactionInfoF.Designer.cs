namespace FuelStation.Win {
    partial class TransactionInfoF {
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
            this.components = new System.ComponentModel.Container();
            this.bsTransLines = new System.Windows.Forms.BindingSource(this.components);
            this.grvTransLines = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransLines
            // 
            this.grvTransLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.ItemPrice,
            this.NetValue,
            this.TotalValue});
            this.grvTransLines.Location = new System.Drawing.Point(169, 70);
            this.grvTransLines.Name = "grvTransLines";
            this.grvTransLines.RowTemplate.Height = 25;
            this.grvTransLines.Size = new System.Drawing.Size(486, 150);
            this.grvTransLines.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "ItemPrice";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // NetValue
            // 
            this.NetValue.DataPropertyName = "NetValue";
            this.NetValue.HeaderText = "NetValue";
            this.NetValue.Name = "NetValue";
            this.NetValue.ReadOnly = true;
            // 
            // TotalValue
            // 
            this.TotalValue.DataPropertyName = "TotalValue";
            this.TotalValue.HeaderText = "TotalValue";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            // 
            // TransactionInfoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grvTransLines);
            this.Name = "TransactionInfoF";
            this.Text = "TransactionInfoF";
            this.Load += new System.EventHandler(this.TransactionInfoF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bsTransLines;
        private DataGridView grvTransLines;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewTextBoxColumn NetValue;
        private DataGridViewTextBoxColumn TotalValue;
    }
}