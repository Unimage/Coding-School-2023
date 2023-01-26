namespace Session_11 {
    partial class ProductF {
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
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.Location = new System.Drawing.Point(12, 12);
            this.grdProduct.MainView = this.grvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(776, 292);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.UseEmbeddedNavigator = true;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProduct});
            // 
            // grvProduct
            // 
            this.grvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colPrice,
            this.colCost});
            this.grvProduct.GridControl = this.grdProduct;
            this.grvProduct.Name = "grvProduct";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colCost
            // 
            this.colCost.Caption = "Cost";
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            // 
            // ProductF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProduct);
            this.Name = "ProductF";
            this.Text = "ProductF";
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
    }
}