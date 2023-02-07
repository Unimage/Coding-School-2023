using CoffeeShop.Model;
using CoffeeShop.Orm.Repositories;
using DevExpress.XtraEditors;
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
    public partial class ProductCategoryF : XtraForm {
        public ProductCategoryRepo prodCatRepo = new ProductCategoryRepo();
        CoffeeShopHandler ShopCategory { get; set; } = new();

        public ProductCategoryF(CoffeeShopHandler transfer) {
            ShopCategory = transfer;
            InitializeComponent();
            bsProductCategory.DataSource = prodCatRepo.GetAll();
            gcProductCategory.DataSource = bsProductCategory;
        }
        private void ResetProductCategoryGVs() {
            bsProductCategory.DataSource = null;
            bsProductCategory.DataSource = prodCatRepo.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            if (tboxAddCategory.Text != null && tboxDescription.Text != null && comboProductType.SelectedItem != null) {
                ProductCategory tmpCateg = new ProductCategory() {
                    Code = tboxAddCategory.Text,
                    Description = tboxDescription.Text,
                    ProductType = (ProductType)Enum.Parse(typeof(ProductType), comboProductType.SelectedItem.ToString())
                };
                prodCatRepo.Create(tmpCateg);
                ResetProductCategoryGVs();
            }
            else { MessageBox.Show("Cant add with Empty Data information"); }

        }
        private void btnFetch_Click(object sender, EventArgs e) {
            ResetProductCategoryGVs();
        }
        private void btnUpdateChanges_Click(object sender, EventArgs e) {
            var item = bsProductCategory.Current as ProductCategory;
            if (item is null)
                return;
            prodCatRepo.Update(item.ID, item);
            ResetProductCategoryGVs();

        }
        private void btnDelete_Click(object sender, EventArgs e) {
            var item = bsProductCategory.Current as ProductCategory;
            if (item is null)
                return;
            prodCatRepo.Delete(item.ID);
            ResetProductCategoryGVs();
        }
    }
}
