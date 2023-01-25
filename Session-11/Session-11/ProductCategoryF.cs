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

        CoffeeShopHandler CoffeeShop;

        public ProductCategoryF() {
            InitializeComponent();
        }

        private void ProductCategoryF_Load(object sender, EventArgs e) {

            PopulateData();

        }

        private void PopulateData() {

            ProductCategory productCategory = new ProductCategory();

           


           

        }

       
    }
}
