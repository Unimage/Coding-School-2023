﻿using Libs;
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
    
    public partial class ProductF : Form {

        CoffeeShopHandler ProductData = new();

        public ProductF(CoffeeShopHandler data) {
            ProductData = data;
            InitializeComponent();
            grdProduct.DataSource = ProductData.Products;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e) {
            ProductData.SerializeProduct();
            MessageBox.Show("JSON exported");
        }

        private void btnLoadProduct_Click(object sender, EventArgs e) {
            ProductData.CheckAndPopulateProducts();
            MessageBox.Show("Loading product data from Json\nIn case of fail it will roll Back To Default Values");
        }

        private void btnAddNew_Click(object sender, EventArgs e) {
            bsProducts.AddNew(); // Not working
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e) {
            bsProducts.RemoveCurrent(); // Not working
        }
    }

}
