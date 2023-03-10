using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {

    public partial class TransactionF : Form {
        private LoginStatus _loginStatus;
        private List<TransactionListViewModel> transactions = new List<TransactionListViewModel>();
        private List<EmployeeListViewModel> employees = new List<EmployeeListViewModel>();
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };

        public TransactionF(LoginStatus loginStatus) {
            _loginStatus = loginStatus;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public async void Setup() {
            employees = await httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            var AllowedEmployees = employees.Where(x => x.EmployeeType == Model.Enumerations.EmployeeType.Manager ||  x.EmployeeType == Model.Enumerations.EmployeeType.Cashier);
            AllowedEmployees = AllowedEmployees.Where(x => x.HireDateEnd == null);
            bsEmployees.DataSource = AllowedEmployees;
            gridEmployees.DataSource = bsEmployees;
            transactions= await httpClient.GetFromJsonAsync<List<TransactionListViewModel>>("transaction");
            bsTransactions.DataSource = transactions;
            gridTransactions.DataSource = bsTransactions;
        }
        private void TransactionF_Load(object sender, EventArgs e) {
            Setup();
        }



        private void btnOrder_Click(object sender, EventArgs e) {
            var frm = new SearchCustomerF(_loginStatus);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK || frm.DialogResult == DialogResult.Cancel || frm.DialogResult == DialogResult.Abort) { Setup(); }
        }

        private void btnEmployeeTransactions_Click(object sender, EventArgs e) {
            if(_loginStatus.EmployeeType == Model.Enumerations.EmployeeType.Manager) {
                var SelectedEmployee = bsEmployees.Current as EmployeeListViewModel;
                var form = new EmployeeTransactionList(SelectedEmployee, transactions);
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK || form.DialogResult == DialogResult.Cancel || form.DialogResult == DialogResult.Abort) { Setup(); }
            }
            else { MessageBox.Show("Only Managers Are authorized Transactions of Other Employees"); }
        }

        private void btnTransactionDetails_Click(object sender, EventArgs e) {
            TransactionListViewModel selected  = bsTransactions.Current as TransactionListViewModel;
            if(selected != null) { 
            var selectedForm = new SelectedTransactionDetailsF(selected);
            selectedForm.ShowDialog();

            if (selectedForm.DialogResult == DialogResult.OK || selectedForm.DialogResult == DialogResult.Cancel || selectedForm.DialogResult == DialogResult.Abort) { Setup(); }
            }
            else { MessageBox.Show("There is nothing to see here yet"); }

        }
    }
}
