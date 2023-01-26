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
            this.gcProductCategory = new DevExpress.XtraGrid.GridControl();
            this.grvProductCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReloadCategories = new System.Windows.Forms.Button();
            this.btnReloadFromJson = new System.Windows.Forms.Button();
            this.btnExportToJson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewProductCategory = new System.Windows.Forms.TextBox();
            this.tboxAddCategory = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.tboxDescription = new System.Windows.Forms.TextBox();
            this.tboxProductType = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddProductType = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtProductCategories = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProductCategory
            // 
            this.gcProductCategory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductCategory.Location = new System.Drawing.Point(68, 49);
            this.gcProductCategory.MainView = this.grvProductCategory;
            this.gcProductCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcProductCategory.Name = "gcProductCategory";
            this.gcProductCategory.Size = new System.Drawing.Size(785, 299);
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
            this.grvProductCategory.DetailHeight = 467;
            this.grvProductCategory.GridControl = this.gcProductCategory;
            this.grvProductCategory.Name = "grvProductCategory";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 86;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 86;
            // 
            // colProductType
            // 
            this.colProductType.Caption = "Product Type";
            this.colProductType.FieldName = "Product Type";
            this.colProductType.MinWidth = 25;
            this.colProductType.Name = "colProductType";
            this.colProductType.Visible = true;
            this.colProductType.VisibleIndex = 2;
            this.colProductType.Width = 86;
            // 
            // btnReloadCategories
            // 
            this.btnReloadCategories.Location = new System.Drawing.Point(68, 375);
            this.btnReloadCategories.Name = "btnReloadCategories";
            this.btnReloadCategories.Size = new System.Drawing.Size(169, 44);
            this.btnReloadCategories.TabIndex = 1;
            this.btnReloadCategories.Text = "Reload Categories";
            this.btnReloadCategories.UseVisualStyleBackColor = true;
            // 
            // btnReloadFromJson
            // 
            this.btnReloadFromJson.Location = new System.Drawing.Point(307, 375);
            this.btnReloadFromJson.Name = "btnReloadFromJson";
            this.btnReloadFromJson.Size = new System.Drawing.Size(135, 44);
            this.btnReloadFromJson.TabIndex = 2;
            this.btnReloadFromJson.Text = "Reload from JSon";
            this.btnReloadFromJson.UseVisualStyleBackColor = true;
            this.btnReloadFromJson.Click += new System.EventHandler(this.btnReloadFromJson_Click_1);
            // 
            // btnExportToJson
            // 
            this.btnExportToJson.Location = new System.Drawing.Point(502, 375);
            this.btnExportToJson.Name = "btnExportToJson";
            this.btnExportToJson.Size = new System.Drawing.Size(155, 44);
            this.btnExportToJson.TabIndex = 3;
            this.btnExportToJson.Text = "Export To JSon";
            this.btnExportToJson.UseVisualStyleBackColor = true;
            this.btnExportToJson.Click += new System.EventHandler(this.btnExportToJson_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Force Default Load ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewProductCategory
            // 
            this.txtNewProductCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNewProductCategory.Location = new System.Drawing.Point(354, 440);
            this.txtNewProductCategory.Name = "txtNewProductCategory";
            this.txtNewProductCategory.Size = new System.Drawing.Size(230, 34);
            this.txtNewProductCategory.TabIndex = 5;
            this.txtNewProductCategory.Text = "New Product Category";
            // 
            // tboxAddCategory
            // 
            this.tboxAddCategory.Location = new System.Drawing.Point(68, 526);
            this.tboxAddCategory.Name = "tboxAddCategory";
            this.tboxAddCategory.Size = new System.Drawing.Size(169, 27);
            this.tboxAddCategory.TabIndex = 6;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(117, 493);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(77, 27);
            this.txtAdd.TabIndex = 7;
            this.txtAdd.Text = "Add Code";
            // 
            // tboxDescription
            // 
            this.tboxDescription.Location = new System.Drawing.Point(286, 526);
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(169, 27);
            this.tboxDescription.TabIndex = 8;
            // 
            // tboxProductType
            // 
            this.tboxProductType.Location = new System.Drawing.Point(488, 526);
            this.tboxProductType.Name = "tboxProductType";
            this.tboxProductType.Size = new System.Drawing.Size(169, 27);
            this.tboxProductType.TabIndex = 9;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(317, 493);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(125, 27);
            this.txtAddDescription.TabIndex = 10;
            this.txtAddDescription.Text = "Add Description";
            // 
            // txtAddProductType
            // 
            this.txtAddProductType.Location = new System.Drawing.Point(502, 493);
            this.txtAddProductType.Name = "txtAddProductType";
            this.txtAddProductType.Size = new System.Drawing.Size(136, 27);
            this.txtAddProductType.TabIndex = 11;
            this.txtAddProductType.Text = "Add Product Type";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(716, 493);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(138, 59);
            this.btnAddCategory.TabIndex = 12;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // txtProductCategories
            // 
            this.txtProductCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductCategories.Location = new System.Drawing.Point(373, 12);
            this.txtProductCategories.Name = "txtProductCategories";
            this.txtProductCategories.Size = new System.Drawing.Size(190, 34);
            this.txtProductCategories.TabIndex = 13;
            this.txtProductCategories.Text = "Product Categories";
            // 
            // ProductCategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.txtProductCategories);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtAddProductType);
            this.Controls.Add(this.txtAddDescription);
            this.Controls.Add(this.tboxProductType);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.tboxAddCategory);
            this.Controls.Add(this.txtNewProductCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportToJson);
            this.Controls.Add(this.btnReloadFromJson);
            this.Controls.Add(this.btnReloadCategories);
            this.Controls.Add(this.gcProductCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductCategoryF";
            this.Text = "ProductCategoryF";
            this.Load += new System.EventHandler(this.ProductCategoryF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProductCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProductCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductType;
        private Button btnReloadCategories;
        private Button btnReloadFromJson;
        private Button btnExportToJson;
        private Button button1;
        private TextBox txtNewProductCategory;
        private TextBox tboxAddCategory;
        private TextBox txtAdd;
        private TextBox tboxDescription;
        private TextBox tboxProductType;
        private TextBox txtAddDescription;
        private TextBox txtAddProductType;
        private Button btnAddCategory;
        private TextBox txtProductCategories;
    }
}