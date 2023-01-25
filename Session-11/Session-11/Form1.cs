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
            bsProducts.DataSource = CoffeeShop.Products; 

        }

        public void SetControlProperties(){
            grvProducts.AutoGenerateColumns = false;
            grvProducts.DataSource = bsProducts;
            grvProducts.Columns[0].DataPropertyName = "Description";
            grvProducts.Columns[1].DataPropertyName = "Code";
            grvProducts.Columns[3].DataPropertyName = "Price";



        }

        private void button1_Click(object sender, EventArgs e) {
            load();
            SetControlProperties();
        }

        private void grvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == grvProducts.Columns["colbtnadd"].Index) {
                DataGridViewRow row = grvProducts.Rows[e.RowIndex];

                translinetobeadded = new();
                translinetobeadded.Quantity = Int32.Parse(row.Cells["colQuantity"].Value.ToString()) ;
                translinetobeadded.Price = Decimal.Parse(row.Cells["colPrice"].Value.ToString());
                Transaction.AddTransactionLines(translinetobeadded);

            }



        }

        private void btnNewOrder_Click(object sender, EventArgs e) {
            tmp = true;
            
            grvTransaction.DataSource = Transaction._transaction.TransactionLines;


        }
    }
}