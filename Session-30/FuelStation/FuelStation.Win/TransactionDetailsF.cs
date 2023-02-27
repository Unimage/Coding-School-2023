using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;
using FuelStation.Model.Enumerations;
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
    public partial class TransactionDetailsF : Form {
        private EmployeeViewModel employee = new();
        private CustomerViewModel customer = new();
        private readonly TransactionHandler _transactionHandler;
        private List<ItemListViewModel> itemList = new();
        private List<TransactionListViewModel> transactions = new List<TransactionListViewModel>();
        private List<TransactionLineViewModel> newTransactionLineList = new();
        private TransactionListViewModel newTransaction = new();
        private Guid _tmpCus;
        private Guid _tmpEmp;
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        public TransactionDetailsF(Guid employeeID , Guid customerID) {
            _tmpEmp= employeeID;
            _tmpCus= customerID;
            _transactionHandler = new();

            newTransaction.Date = DateTime.Now;
            newTransaction.EmployeeID = employeeID;
            newTransaction.CustomerID = customerID;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }
        public async void LoadData() {
            customer = await httpClient.GetFromJsonAsync<CustomerViewModel>($"customer/{_tmpCus}");
            employee = await httpClient.GetFromJsonAsync<EmployeeViewModel>($"employee/{_tmpEmp}");
            itemList = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
            transactions = await httpClient.GetFromJsonAsync<List<TransactionListViewModel>>("transaction");
            bsItems.DataSource = itemList;
            bsTransactionLines.DataSource = newTransactionLineList;
            gridProducts.DataSource = bsItems;
            gridTransactionLines.DataSource = bsTransactionLines;
            cmbPayment.DataSource = Enum.GetValues(typeof(PaymentMethod));
            bsTransactions.DataSource = transactions; 
        }
        private void TransactionDetailsF_Load(object sender, EventArgs e) {
            LoadData();  
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CreateNewLine();
            RefreshGrids();
        }
        private void CreateNewLine() {
            var selectedItem = bsItems.Current as ItemListViewModel;
            if (selectedItem is null) return;

            if (_transactionHandler.CanAddFuelItem(newTransactionLineList, selectedItem.ItemType)) {
                newTransactionLineList.Add(_transactionHandler.AddTransactionLine(
                newTransaction.ID, selectedItem, Convert.ToInt32(spinEditQuantity.Text)));

                UpdateNewTransaction();
            }
            else {
                MessageBox.Show("Can not add more than one item of type 'Fuel'.");
                return;
            }
        }
        private void UpdateNewTransaction() {
            newTransaction = _transactionHandler.UpdateTransaction(newTransaction, newTransactionLineList);
        }
        private void RefreshGrids() {
            bsTransactionLines.DataSource = null;
            bsTransactionLines.DataSource = newTransactionLineList;
            gridTransactionLines.DataSource = null;
            gridTransactionLines.DataSource = bsTransactionLines;
            gridTransactionLines.Refresh();
            gridTransactionLines.RefreshDataSource();

            labelTotalPrice.Text = $"Total: {newTransaction.TotalValue} €";

            spinEditQuantity.Text = "1";
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (ConfirmDelete()) {
                DeleteTransactionLine();
            }

        }
        private bool ConfirmDelete() {
            var result = MessageBox.Show(this, "Procceed With Deleting Selected Transaction Line?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void DeleteTransactionLine() {
            var line = bsTransactionLines.Current as TransactionLineViewModel;
            if (line is null)
                return;
            bsTransactionLines.Remove(line);
            newTransactionLineList.Remove(line);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            
            if (newTransactionLineList.Count > 0) {
                SaveTransaction();
            }
            else {
                MessageBox.Show(this, $"There Are Transaction Lines in this Transaction");     
            }
        }
        private async void SaveTransaction() {
            newTransaction.ID = Guid.NewGuid();
            newTransaction.PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), cmbPayment.SelectedItem.ToString());
            if (_transactionHandler.CheckPaymentMethod(newTransaction.TotalValue) && newTransaction.PaymentMethod == PaymentMethod.Cash)
                {
                newTransaction.CustomerCardNumber = customer.CardNumber;
                newTransaction.EmployeeName = employee.Name + employee.Surname;

                var result = await httpClient.PostAsJsonAsync("transaction", newTransaction);
                if ((int)result.StatusCode == 200) {
                    MessageBox.Show("Transaction Created");
                    foreach (var line in newTransactionLineList) {
                        line.TransactionID = newTransaction.ID;
                        var resultLine = await httpClient.PostAsJsonAsync("transactionline", line);
                    }
                }
            }
            else { MessageBox.Show("Total Price Restricts the use of Card as Payment Method.\n Please use cash!"); }
        }
 
        }
    }

