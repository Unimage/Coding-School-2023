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

namespace Session_11
{
    public partial class CoffeeShopF : Form
    {
        TransactionHandler Transaction;
        CoffeeShopHandler CoffeeShop;
        MonthlyLedger LedgerOfTheMonth;
        TransactionLine translinetobeadded;
        bool tmp = false;

        public CoffeeShopF()
        {

            CoffeeShop = new CoffeeShopHandler();
            Transaction = new TransactionHandler();
            LedgerOfTheMonth = new MonthlyLedger();
            InitializeComponent();
            CoffeeShop.Init();
        }

        private void load()
        {

        }

        private void btnEmployeeRedirect_Click(object sender, EventArgs e)
        {
            EmployeeF formEmp = new EmployeeF(CoffeeShop);
            formEmp.ShowDialog();
        }

        private void btnLoadLedger_Click(object sender, EventArgs e)
        {
            LedgerForm ledgerForm = new LedgerForm();
            ledgerForm.ShowDialog();
        }
    }
}