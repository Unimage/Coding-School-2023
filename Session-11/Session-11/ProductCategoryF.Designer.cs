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
            this.grdProductCategory = new DevExpress.XtraGrid.GridControl();
            this.grvProductCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReloadCategories = new System.Windows.Forms.Button();
            this.btnReloadFromJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductCategory
            // 
            this.grdProductCategory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdProductCategory.Location = new System.Drawing.Point(68, 1);
            this.grdProductCategory.MainView = this.grvProductCategory;
            this.grdProductCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdProductCategory.Name = "grdProductCategory";
            this.grdProductCategory.Size = new System.Drawing.Size(785, 400);
            this.grdProductCategory.TabIndex = 0;
            this.grdProductCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProductCategory});
            // 
            // grvProductCategory
            // 
            this.grvProductCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colProductType});
            this.grvProductCategory.DetailHeight = 467;
            this.grvProductCategory.GridControl = this.grdProductCategory;
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
            this.btnReloadCategories.Location = new System.Drawing.Point(68, 436);
            this.btnReloadCategories.Name = "btnReloadCategories";
            this.btnReloadCategories.Size = new System.Drawing.Size(94, 29);
            this.btnReloadCategories.TabIndex = 1;
            this.btnReloadCategories.Text = "Reload Categories";
            this.btnReloadCategories.UseVisualStyleBackColor = true;
           // this.btnReloadCategories.Click += new System.EventHandler(this.btnReloadCategories_Click);
            // 
            // btnReloadFromJson
            // 
            this.btnReloadFromJson.Location = new System.Drawing.Point(300, 436);
            this.btnReloadFromJson.Name = "btnReloadFromJson";
            this.btnReloadFromJson.Size = new System.Drawing.Size(123, 29);
            this.btnReloadFromJson.TabIndex = 2;
            this.btnReloadFromJson.Text = "Reload from JSon";
            this.btnReloadFromJson.UseVisualStyleBackColor = true;
           // this.btnReloadFromJson.Click += new System.EventHandler(this.btnReloadFromJson_Click);
            // 
            // ProductCategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnReloadFromJson);
            this.Controls.Add(this.btnReloadCategories);
            this.Controls.Add(this.grdProductCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductCategoryF";
            this.Text = "ProductCategoryF";
            this.Load += new System.EventHandler(this.ProductCategoryF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProductCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProductCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProductType;
        private Button btnReloadCategories;
        private Button btnReloadFromJson;
    }
}