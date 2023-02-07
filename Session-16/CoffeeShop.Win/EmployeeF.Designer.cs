namespace Session_11
{
    partial class EmployeeF
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
            this.components = new System.ComponentModel.Container();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.Role = new System.Windows.Forms.Label();
            this.tboxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEmployee
            // 
            this.gcEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcEmployee.Location = new System.Drawing.Point(83, 63);
            this.gcEmployee.MainView = this.gridView1;
            this.gcEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(445, 187);
            this.gcEmployee.TabIndex = 0;
            this.gcEmployee.UseEmbeddedNavigator = true;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcSurname,
            this.gcEmployeeType,
            this.gcSalary});
            this.gridView1.DetailHeight = 304;
            this.gridView1.GridControl = this.gcEmployee;
            this.gridView1.Name = "gridView1";
            // 
            // gcName
            // 
            this.gcName.Caption = "Name";
            this.gcName.FieldName = "Name";
            this.gcName.MinWidth = 17;
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            this.gcName.Width = 64;
            // 
            // gcSurname
            // 
            this.gcSurname.Caption = "Surname";
            this.gcSurname.FieldName = "Surname";
            this.gcSurname.MinWidth = 17;
            this.gcSurname.Name = "gcSurname";
            this.gcSurname.Visible = true;
            this.gcSurname.VisibleIndex = 1;
            this.gcSurname.Width = 64;
            // 
            // gcEmployeeType
            // 
            this.gcEmployeeType.Caption = "Role";
            this.gcEmployeeType.FieldName = "EmployeeType";
            this.gcEmployeeType.MinWidth = 17;
            this.gcEmployeeType.Name = "gcEmployeeType";
            this.gcEmployeeType.Visible = true;
            this.gcEmployeeType.VisibleIndex = 2;
            this.gcEmployeeType.Width = 64;
            // 
            // gcSalary
            // 
            this.gcSalary.Caption = "Salary";
            this.gcSalary.FieldName = "Salary";
            this.gcSalary.MinWidth = 17;
            this.gcSalary.Name = "gcSalary";
            this.gcSalary.Visible = true;
            this.gcSalary.VisibleIndex = 3;
            this.gcSalary.Width = 64;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(83, 255);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Employee Roster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Employee Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(113, 365);
            this.tboxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(86, 21);
            this.tboxName.TabIndex = 5;
            // 
            // tboxSurname
            // 
            this.tboxSurname.Location = new System.Drawing.Point(222, 365);
            this.tboxSurname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxSurname.Name = "tboxSurname";
            this.tboxSurname.Size = new System.Drawing.Size(86, 21);
            this.tboxSurname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Barista",
            "Waiter"});
            this.comboRole.Location = new System.Drawing.Point(339, 365);
            this.comboRole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(104, 21);
            this.comboRole.TabIndex = 8;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(375, 349);
            this.Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(28, 13);
            this.Role.TabIndex = 9;
            this.Role.Text = "Role";
            // 
            // tboxSalary
            // 
            this.tboxSalary.Location = new System.Drawing.Point(482, 365);
            this.tboxSalary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxSalary.Name = "tboxSalary";
            this.tboxSalary.Size = new System.Drawing.Size(86, 21);
            this.tboxSalary.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salary";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 256);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 39);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 255);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(319, 256);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(107, 39);
            this.btnFetch.TabIndex = 15;
            this.btnFetch.Text = "Fetch Data";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // EmployeeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 421);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxSalary);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxSurname);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gcEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EmployeeF";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn gcSalary;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tboxName;
        private TextBox tboxSurname;
        private Label label4;
        private ComboBox comboRole;
        private Label Role;
        private TextBox tboxSalary;
        private Label label5;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLoadDefault;
        private Button btnFetch;
        private BindingSource bsEmployees;
    }
}