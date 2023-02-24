namespace FuelStation.Win {
    partial class TransactionF {
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
            this.gridTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEmployees = new DevExpress.XtraGrid.GridControl();
            this.grvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.btnEmployeeTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransactionDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTransactions
            // 
            this.gridTransactions.EmbeddedNavigator.Enabled = false;
            this.gridTransactions.Location = new System.Drawing.Point(13, 42);
            this.gridTransactions.MainView = this.grvTransactions;
            this.gridTransactions.Name = "gridTransactions";
            this.gridTransactions.Size = new System.Drawing.Size(928, 243);
            this.gridTransactions.TabIndex = 4;
            this.gridTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            this.gridTransactions.Load += new System.EventHandler(this.TransactionF_Load);
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerCardNumber,
            this.EmployeeName,
            this.colDate,
            this.colPaymentMethod,
            this.colTotalValue});
            this.grvTransactions.DetailHeight = 397;
            this.grvTransactions.GridControl = this.gridTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.OptionsBehavior.Editable = false;
            this.grvTransactions.OptionsView.ShowGroupPanel = false;
            // 
            // CustomerCardNumber
            // 
            this.CustomerCardNumber.Caption = "Card Number";
            this.CustomerCardNumber.FieldName = "CustomerCardNumber";
            this.CustomerCardNumber.Name = "CustomerCardNumber";
            this.CustomerCardNumber.Visible = true;
            this.CustomerCardNumber.VisibleIndex = 0;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 4;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 66;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.Caption = "Payment Method";
            this.colPaymentMethod.FieldName = "PaymentMethod";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.Visible = true;
            this.colPaymentMethod.VisibleIndex = 2;
            this.colPaymentMethod.Width = 66;
            // 
            // colTotalValue
            // 
            this.colTotalValue.Caption = "Total Price";
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 3;
            this.colTotalValue.Width = 66;
            // 
            // gridEmployees
            // 
            this.gridEmployees.EmbeddedNavigator.Enabled = false;
            this.gridEmployees.Location = new System.Drawing.Point(13, 330);
            this.gridEmployees.MainView = this.grvEmployees;
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(928, 206);
            this.gridEmployees.TabIndex = 7;
            this.gridEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployees});
            // 
            // grvEmployees
            // 
            this.grvEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colType});
            this.grvEmployees.DetailHeight = 397;
            this.grvEmployees.GridControl = this.gridEmployees;
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.OptionsBehavior.Editable = false;
            this.grvEmployees.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "EmployeeType";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(774, 542);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(167, 38);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Add New Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnEmployeeTransactions
            // 
            this.btnEmployeeTransactions.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEmployeeTransactions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeTransactions.Location = new System.Drawing.Point(13, 542);
            this.btnEmployeeTransactions.Name = "btnEmployeeTransactions";
            this.btnEmployeeTransactions.Size = new System.Drawing.Size(281, 38);
            this.btnEmployeeTransactions.TabIndex = 9;
            this.btnEmployeeTransactions.Text = "Veiw Employee Transactions";
            this.btnEmployeeTransactions.UseVisualStyleBackColor = false;
            this.btnEmployeeTransactions.Click += new System.EventHandler(this.btnEmployeeTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transaction History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Eligible Employee View";
            // 
            // btnTransactionDetails
            // 
            this.btnTransactionDetails.BackColor = System.Drawing.Color.Khaki;
            this.btnTransactionDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransactionDetails.Location = new System.Drawing.Point(660, 289);
            this.btnTransactionDetails.Name = "btnTransactionDetails";
            this.btnTransactionDetails.Size = new System.Drawing.Size(281, 38);
            this.btnTransactionDetails.TabIndex = 12;
            this.btnTransactionDetails.Text = "Veiw Transaction Details";
            this.btnTransactionDetails.UseVisualStyleBackColor = false;
            this.btnTransactionDetails.Click += new System.EventHandler(this.btnTransactionDetails_Click);
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 593);
            this.Controls.Add(this.btnTransactionDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployeeTransactions);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.gridTransactions);
            this.Name = "TransactionF";
            this.Text = "TransactionF";
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
        private DevExpress.XtraGrid.GridControl gridEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private Button btnOrder;
        private BindingSource bsEmployees;
        private BindingSource bsTransactions;
        private Button btnEmployeeTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerCardNumber;
        private Label label1;
        private Label label2;
        private Button btnTransactionDetails;
    }
}