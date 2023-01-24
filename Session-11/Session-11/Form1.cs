using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11 {
    public partial class Form1 : Form {
        TransactionHandler Transaction;
            CoffeeShopHandler CoffeeShop;
        public Form1() {
            MonthlyLedger ledger;
            CoffeeShop = new CoffeeShopHandler();
            Transaction = new TransactionHandler();   
            
            InitializeComponent();   
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }
        private void load() {
            CoffeeShop.Init();
            bsEmployees.DataSource = CoffeeShop.Employees;
            bsProductCategory.DataSource = CoffeeShop.ProductCategories;
            bsProducts.DataSource = CoffeeShop.Products;
            bsTransaction.DataSource = Transaction._transaction;
            dgvEmployees.DataSource = bsEmployees;
            dgvProductCategory.DataSource = bsProductCategory;
            dgvProducts.DataSource = bsProducts;
            dgvTransaction.DataSource = bsTransaction;
            CoffeeShop.Save();

        }

        private void button1_Click(object sender, EventArgs e) {
            load();
            MessageBox.Show("To teliko poso einai " +  Transaction._transaction.TotalPrice);
        }

        private void dgvProductCategory_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}