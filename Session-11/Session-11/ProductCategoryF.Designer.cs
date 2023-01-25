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
            ((System.ComponentModel.ISupportInitialize)(this.grdProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductCategory
            // 
            this.grdProductCategory.Location = new System.Drawing.Point(44, 38);
            this.grdProductCategory.MainView = this.grvProductCategory;
            this.grdProductCategory.Name = "grdProductCategory";
            this.grdProductCategory.Size = new System.Drawing.Size(687, 300);
            this.grdProductCategory.TabIndex = 0;
            this.grdProductCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProductCategory});
            // 
            // grvProductCategory
            // 
            this.grvProductCategory.GridControl = this.grdProductCategory;
            this.grvProductCategory.Name = "grvProductCategory";
            // 
            // ProductCategoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdProductCategory);
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
    }
}