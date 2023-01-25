using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11 {


    

    public partial class ProductCategoryF : Form {

        CoffeeShopHandler ShopCategory { get; set; } = new();

        public ProductCategoryF(CoffeeShopHandler transfer) {

            ShopCategory = transfer;
            InitializeComponent();

            grdProductCategory.DataSource = ShopCategory.ProductCategories;
        }

        private void ProductCategoryF_Load(object sender, EventArgs e)
        {

        }

        /*private void ProductCategoryF_Load(object sender, EventArgs e) {

            PopulateData();

        }*/

        private void PopulateData() {

            ProductCategory productCategory = new ProductCategory();

        }

        private void btnReloadCategories_Click(object sender, EventArgs e)
        {
            grdProductCategory.DataSource = null;
            grdProductCategory.DataSource = ShopCategory.ProductCategories;
        }

        private void btnReloadFromJson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Employee File from Json\nIn case of fail it will roll Back To Default Values");
            ShopCategory.CheckAndPopulateProductCategories();
        }

        /* private void btnReloadProductCategories_EditValueChanged(object sender, EventArgs e)
         {
             grdProductCategory.DataSource = null;
             grdProductCategory.DataSource = ShopCategory.ProductCategories;
         }

         private void btnLoadCategoriesJson_EditValueChanged(object sender, EventArgs e)
         {
             MessageBox.Show("Loading Employee File from Json\nIn case of fail it will roll Back To Default Values");
             ShopCategory.CheckAndPopulateProductCategories();
         }*/
    }
}
