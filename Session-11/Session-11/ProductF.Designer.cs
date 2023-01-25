using Libs;
using System.Drawing.Text;

namespace Session_11
{
    public partial class ProductF : Form 
    {
        CoffeeShopHandler ShopData { get; set; } = new();
        public ProductF(CoffeeShopHandler transfer)
        {
            ShopData= transfer;

            InitializeComponent();
            gcProduct.DataSource = ShopData.Products;
        }
        private void btnRefreshList_Click(object sender,EventArgs e)
        {
            gcProduct.DataSource = null;
            gcProduct.DataSource = ShopData.Products;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product tmpEmp = new Product()
            {
                Code = tboxCode.Text,
                Description = tboxDescription.Text,
                Price = Convert.ToDecimal(tboxPrice.Text),
                Cost = Convert.ToDecimal(tboxCost.Text),
                ProductID = (ProductID)Enum.Parse(typeof(ProductID),
                ProductCategoryID = (ProductCategoryID)Enum.Parse(typeof(ProductCategoryID), comboRole.SelectedItem.ToString())
            };
            ShopData.Product.Add(tmpEmp);
            if (ShopData.CheckLimitsForm())
            {
                MessageBox.Show("New Product Successfully added to Cart!\n Press Reload To See.");
            }
            else {
                ShopData.Product.Remove(tmpEmp);
                MessageBox.Show("Error on the Cart Limits\nPress Reload To See.");
            }
        }
            private void btnLoadJson_Click(object sender,EventArgs e)
            {
                MessageBox.Show("Loading Product File from Json\nIn case of fail it will roll Bact To Default Values");
                ShopData.CheckAndPopulateProducts();
            }
            private void btnSaveEmp_Click(object sender, EventArgs e)
            {
                ShopData.SerializeProduct();
                MessageBox.Show("Exported Successfully!");
            }
    }
}
//ok