using CoffeeShop.Model;
using CoffeeShop.Orm.Repositories;
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
        public ProductCategoryRepo prodCatRepo = new ProductCategoryRepo();

        CoffeeShopHandler ShopCategory { get; set; } = new();

        public ProductCategoryF(CoffeeShopHandler transfer) {
            //loads from db
            ShopCategory = transfer;
            InitializeComponent();
            gcProductCategory.DataSource = prodCatRepo.GetAll();
        }
        public void PopulateData() {
            ProductCategory productCategory = new ProductCategory();
        }
        private void btnReloadCategories_Click(object sender, EventArgs e) {
            gcProductCategory.DataSource = null;
            gcProductCategory.DataSource = prodCatRepo.GetAll();
        }
        //todo:refactor bellow
        private void btnReloadFromJson_Click(object sender, EventArgs e) {
            //MessageBox.Show("Loading Employee File from Json\nIn case of fail it will roll Back To Default Values");
            //ShopCategory.CheckAndPopulateProductCategories();
        }
        private void btnExportToJson_Click(object sender, EventArgs e) {
            //prodCatRepo.
            //ShopCategory.SerializeProductCategory();
            //MessageBox.Show("Exported Successfully!");
        }
        private void ResetProductCategoryGVs() {
            gcProductCategory.DataSource = null;
            gcProductCategory.DataSource = prodCatRepo.GetAll();
        }
        private void button1_Click(object sender, EventArgs e) {
            //ShopCategory.ProductCategories.Clear();
            //ShopCategory.SetDefaultProductCategories();
            //ResetProductCategoryGVs();
        }
        private void btnAddCategory_Click_1(object sender, EventArgs e) {
            if (tboxAddCategory.Text != null && tboxDescription.Text != null && comboProductType.SelectedItem != null) {
                ProductCategory tmpCateg = new ProductCategory() {
                    Code = tboxAddCategory.Text,
                    Description = tboxDescription.Text,
                    ProductType = (ProductType)Enum.Parse(typeof(ProductType), comboProductType.SelectedItem.ToString())
                };
                prodCatRepo.Create(tmpCateg);
                ResetProductCategoryGVs();
            }else { MessageBox.Show("Cant add with Empty Data information"); }
        }
    }
}
