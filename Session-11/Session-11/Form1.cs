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
        MonthlyLedger LedgerOfTheMonth;
        TransactionLine translinetobeadded;
        bool tmp = false;

        public Form1() {
            
            CoffeeShop = new CoffeeShopHandler();
            Transaction = new TransactionHandler();
            LedgerOfTheMonth = new MonthlyLedger();
            InitializeComponent();
        }

        private void load() {
            CoffeeShop.Init();
        }

        private void btnEmployeeRedirect_Click(object sender, EventArgs e) {
            EmployeeF formEmp = new EmployeeF(CoffeeShop);
            formEmp.ShowDialog();
        }
    }        
}