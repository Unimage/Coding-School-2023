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
            gcEmployee = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            gcSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            gcEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            gcSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            btnRefreshList = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tboxName = new TextBox();
            tboxSurname = new TextBox();
            label4 = new Label();
            comboRole = new ComboBox();
            Role = new Label();
            tboxSalary = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            btnLoadJson = new Button();
            btnSaveEmp = new Button();
            ((System.ComponentModel.ISupportInitialize)gcEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gcEmployee
            // 
            gcEmployee.Location = new Point(97, 73);
            gcEmployee.MainView = gridView1;
            gcEmployee.Name = "gcEmployee";
            gcEmployee.Size = new Size(519, 216);
            gcEmployee.TabIndex = 0;
            gcEmployee.UseEmbeddedNavigator = true;
            gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gcName, gcSurname, gcEmployeeType, gcSalary });
            gridView1.GridControl = gcEmployee;
            gridView1.Name = "gridView1";
            // 
            // gcName
            // 
            gcName.Caption = "Name";
            gcName.FieldName = "Name";
            gcName.Name = "gcName";
            gcName.Visible = true;
            gcName.VisibleIndex = 0;
            // 
            // gcSurname
            // 
            gcSurname.Caption = "Surname";
            gcSurname.FieldName = "Surname";
            gcSurname.Name = "gcSurname";
            gcSurname.Visible = true;
            gcSurname.VisibleIndex = 1;
            // 
            // gcEmployeeType
            // 
            gcEmployeeType.Caption = "Role";
            gcEmployeeType.FieldName = "EmployeeType";
            gcEmployeeType.Name = "gcEmployeeType";
            gcEmployeeType.Visible = true;
            gcEmployeeType.VisibleIndex = 2;
            // 
            // gcSalary
            // 
            gcSalary.Caption = "Salary";
            gcSalary.FieldName = "Salary";
            gcSalary.Name = "gcSalary";
            gcSalary.Visible = true;
            gcSalary.VisibleIndex = 3;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Location = new Point(120, 295);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(136, 45);
            btnRefreshList.TabIndex = 1;
            btnRefreshList.Text = "Reload";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 26);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 2;
            label1.Text = "Current Employee Roster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 355);
            label2.Name = "label2";
            label2.Size = new Size(222, 21);
            label2.TabIndex = 3;
            label2.Text = "New Employee Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 403);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // tboxName
            // 
            tboxName.Location = new Point(45, 421);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(100, 23);
            tboxName.TabIndex = 5;
            // 
            // tboxSurname
            // 
            tboxSurname.Location = new Point(167, 421);
            tboxSurname.Name = "tboxSurname";
            tboxSurname.Size = new Size(100, 23);
            tboxSurname.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 403);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Surname";
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Manager", "Cashier", "Barista", "Waiter" });
            comboRole.Location = new Point(290, 421);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(121, 23);
            comboRole.TabIndex = 8;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(323, 403);
            Role.Name = "Role";
            Role.Size = new Size(30, 15);
            Role.TabIndex = 9;
            Role.Text = "Role";
            // 
            // tboxSalary
            // 
            tboxSalary.Location = new Point(442, 421);
            tboxSalary.Name = "tboxSalary";
            tboxSalary.Size = new Size(100, 23);
            tboxSalary.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 403);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "Salary";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(579, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Location = new Point(304, 295);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(120, 45);
            btnLoadJson.TabIndex = 13;
            btnLoadJson.Text = "Load From Json";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // btnSaveEmp
            // 
            btnSaveEmp.Location = new Point(476, 295);
            btnSaveEmp.Name = "btnSaveEmp";
            btnSaveEmp.Size = new Size(120, 45);
            btnSaveEmp.TabIndex = 14;
            btnSaveEmp.Text = "Export To Json";
            btnSaveEmp.UseVisualStyleBackColor = true;
            btnSaveEmp.Click += btnSaveEmp_Click;
            // 
            // EmployeeF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 486);
            Controls.Add(btnSaveEmp);
            Controls.Add(btnLoadJson);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(tboxSalary);
            Controls.Add(Role);
            Controls.Add(comboRole);
            Controls.Add(label4);
            Controls.Add(tboxSurname);
            Controls.Add(tboxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefreshList);
            Controls.Add(gcEmployee);
            Name = "EmployeeF";
            Text = "Employee";
            Load += EmployeeF_Load;
            ((System.ComponentModel.ISupportInitialize)gcEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn gcSalary;
        private Button btnRefreshList;
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
        private Button btnLoadJson;
        private Button btnSaveEmp;
    }
}