using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.ViewModels;
using Newtonsoft.Json;
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
    public partial class CustomerListF : Form {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        private List<CustomerListViewModel> customerList = new();
        public CustomerListF() {
            InitializeComponent();
        }
        public async Task SetUpBindings() {
            customerList = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
            grdCustomers.AutoGenerateColumns = false;
            bsCustomers.DataSource = customerList;
            grdCustomers.DataSource = bsCustomers;
        }
        private async void FormCustomerList_Load(object sender, EventArgs e) {
            try {
                SetUpBindings();
            }
            catch (Exception ex) {
                MessageBox.Show(this, $"Error retrieving Data from database.\n[{ex}]",
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            CallEdit(null);
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            if (bsCustomers.Current is CustomerListViewModel customer) {
                CallEdit(customer);
            }
        }
        private void CallEdit(CustomerListViewModel? customer) {
            if (customer is null) {
                customer = new CustomerListViewModel();
                customer.ID = Guid.Empty;
            }
            var customerEditForm = new CustomerEditF(customer);
            customerEditForm.ShowDialog();
        }
    }
}
