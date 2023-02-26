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
    public partial class EmployeeTransactionList : Form {
        private List<TransactionListViewModel> _transactions = new();
        private EmployeeListViewModel _employee = new();
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        public EmployeeTransactionList(EmployeeListViewModel employee , List<TransactionListViewModel> transactions) {
            _transactions = transactions;
            _employee = employee;

            InitializeComponent();
        }

        public async void Setup() {
            label1.Text = "List of Transactions Registered to: " + _employee.Name + " " + _employee.Surname;
            grdTransactions.AutoGenerateColumns = false;
            var verifiedTransactions = _transactions.Where(x => x.EmployeeID == _employee.ID);
            bsTransactions.DataSource = verifiedTransactions;
            grdTransactions.DataSource = bsTransactions;
        }

        private void EmployeeTransactionList_Load(object sender, EventArgs e) {
            Setup();
        }

        private void button1_Click(object sender, EventArgs e) {
            TransactionListViewModel selected = bsTransactions.Current as TransactionListViewModel;
            var selectedForm = new SelectedTransactionDetailsF(selected);
            selectedForm.ShowDialog();
        }
    }
}
