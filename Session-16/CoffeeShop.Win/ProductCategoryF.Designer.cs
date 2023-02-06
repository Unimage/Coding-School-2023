namespace Session_11 {
    partial class ProductCategoryF {
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
            this.gcProductCategory = new DevExpress.XtraGrid.GridControl();
            this.grvProductCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdateChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.tboxAddCategory = new System.Windows.Forms.TextBox();
            this.tboxDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboProductType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bsProductCategory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProductCategory
            // 
            this.gcProductCategory.Location = new System.Drawing.Point(34, 50);
            this.gcProductCategory.MainView = this.grvProductCategory;
            this.gcProductCategory.Name = "gcProductCategory";
            this.gcProductCategory.Size = new System.Drawing.Size(589, 194);
            this.gcProductCategory.TabIndex = 0;
            this.gcProductCategory.UseEmbeddedNavigator = true;
            this.gcProductCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProductCategory});
            // 
            // grvProductCategory
            // 
            this.grvProductCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colProductType});
            this.grvProductCategory.DetailHeight = 303;
            this.grvProductCategory.GridControl = this.gcProductCategory;
            this.grvProductCategory.Name = "grvProductCategory";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 19;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 64;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 19;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 64;
            // 
            // colProductType
            // 
            this.colProductType.Caption = "Product Type";
            this.colProductType.FieldName = "ProductType";
            this.colProductType.MinWidth = 19;
            this.colProductType.Name = "colProductType";
            this.colProductType.Visible = true;
            this.colProductType.VisibleIndex = 2;
            this.colProductType.Width = 64;
            // 
            // btnUpdateChanges
            // 
            this.btnUpdateChanges.Location = new System.Drawing.Point(314, 315);
            this.btnUpdateChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateChanges.Name = "btnUpdateChanges";
            this.btnUpdateChanges.Size = new System.Drawing.Size(135, 39);
            this.btnUpdateChanges.TabIndex = 1;
            this.btnUpdateChanges.Text = "Save Changes";
            this.btnUpdateChanges.UseVisualStyleBackColor = true;
            this.btnUpdateChanges.Click += new System.EventHandler(this.btnUpdateChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 315);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(453, 315);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(135, 39);
            this.btnFetch.TabIndex = 4;
            this.btnFetch.Text = "Fetch Data";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // tboxAddCategory
            // 
            this.tboxAddCategory.Location = new System.Drawing.Point(34, 290);
            this.tboxAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxAddCategory.Name = "tboxAddCategory";
            this.tboxAddCategory.Size = new System.Drawing.Size(127, 21);
            this.tboxAddCategory.TabIndex = 6;
            // 
            // tboxDescription
            // 
            this.tboxDescription.Location = new System.Drawing.Point(264, 290);
            this.tboxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(127, 21);
            this.tboxDescription.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 315);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboProductType
            // 
            this.comboProductType.FormattingEnabled = true;
            this.comboProductType.Items.AddRange(new object[] {
            "Coffee",
            "Beverages",
            "Food"});
            this.comboProductType.Location = new System.Drawing.Point(455, 290);
            this.comboProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProductType.Name = "comboProductType";
            this.comboProductType.Size = new System.Drawing.Size(121, 21);
            this.comboProductType.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(264, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Desciption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(453, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Category Management";
            // 
            // ProductCategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboProductType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.tboxAddCategory);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateChanges);
            this.Controls.Add(this.gcProductCategory);
            this.Name = "ProductCategoryF";
            this.Text = "ProductCategoryF";
            ((System.ComponentModel.ISupportInitialize)(this.gcProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProductCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProductCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductType;
        private Button btnUpdateChanges;
        private Button btnDelete;
        private Button btnFetch;
        private TextBox tboxAddCategory;
        private TextBox tboxDescription;
        private Button btnAdd;
        private ComboBox comboProductType;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private BindingSource bsProductCategory;
    }
}