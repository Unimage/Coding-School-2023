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

    
    public partial class TransactionF : Form {
        CoffeeShopHandler CoffeeData { get; set; } = new();
        TransactionHandler trans { get; set; } = new();
        TransactionRepo transactonRepo = new TransactionRepo();
        TransactionLineRepo translineRepo = new TransactionLineRepo();
        EmployeeRepo employeeRepo= new EmployeeRepo();
        ProductRepo prodRepo= new ProductRepo();
        public TransactionF(CoffeeShopHandler data, TransactionHandler tr) {
            InitializeComponent();
            bsEmployees.DataSource = employeeRepo.GetAll();
            bsTransactions.DataSource = transactonRepo.GetAll();

        }
        private void TransactionF_Load(object sender, EventArgs e) {
            gridTransactions.DataSource = bsTransactions;
            gridEmployees.DataSource = bsEmployees;
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            trans._transactions = transactonRepo.GetAll();
            CoffeeData.Products = prodRepo.GetAll();
            CoffeeData.Employees = employeeRepo.GetAll();
            var employee = bsEmployees.Current as Employee;
            var transactionDetailForm = new TransactionDetailsF(CoffeeData, employee , trans);
            transactionDetailForm.ShowDialog();
            grvTransactions.RefreshData();
        }
    }
}
