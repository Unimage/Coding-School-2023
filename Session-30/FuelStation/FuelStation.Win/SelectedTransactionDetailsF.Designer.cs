namespace FuelStation.Win {
    partial class SelectedTransactionDetailsF {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvTransLines = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransLines = new System.Windows.Forms.BindingSource(this.components);
            this.labelTransID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransLines
            // 
            this.grvTransLines.AllowUserToAddRows = false;
            this.grvTransLines.AllowUserToDeleteRows = false;
            this.grvTransLines.AllowUserToResizeColumns = false;
            this.grvTransLines.AllowUserToResizeRows = false;
            this.grvTransLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTransLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvTransLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemID,
            this.ItemName,
            this.Quantity,
            this.NetValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTransLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvTransLines.Location = new System.Drawing.Point(74, 114);
            this.grvTransLines.Name = "grvTransLines";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTransLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvTransLines.RowTemplate.Height = 25;
            this.grvTransLines.Size = new System.Drawing.Size(665, 150);
            this.grvTransLines.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
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
            // NetValue
            // 
            this.NetValue.DataPropertyName = "NetValue";
            this.NetValue.HeaderText = "NetValue";
            this.NetValue.Name = "NetValue";
            this.NetValue.ReadOnly = true;
            // 
            // labelTransID
            // 
            this.labelTransID.AutoSize = true;
            this.labelTransID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTransID.Location = new System.Drawing.Point(74, 46);
            this.labelTransID.Name = "labelTransID";
            this.labelTransID.Size = new System.Drawing.Size(68, 30);
            this.labelTransID.TabIndex = 1;
            this.labelTransID.Text = "label1";
            // 
            // SelectedTransactionDetailsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTransID);
            this.Controls.Add(this.grvTransLines);
            this.Name = "SelectedTransactionDetailsF";
            this.Text = "SelectedTransactionDetailsF";
            this.Load += new System.EventHandler(this.SelectedTransactionDetailsF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvTransLines;
        private BindingSource bsTransLines;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn NetValue;
        private Label labelTransID;
    }
}