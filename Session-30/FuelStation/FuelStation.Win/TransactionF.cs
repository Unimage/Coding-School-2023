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
        private List<TransactionBasicViewModel> transactions = new List<TransactionBasicViewModel>();
        private List<EmployeeListViewModel> employees = new List<EmployeeListViewModel>();
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };

        public TransactionF() {
            InitializeComponent();
        }
        public async void Setup() {
            employees = await httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            var AllowedEmployees = employees.Where(x => x.EmployeeType == Model.Enumerations.EmployeeType.Manager ||  x.EmployeeType == Model.Enumerations.EmployeeType.Cashier);
            bsEmployees.DataSource = AllowedEmployees;
            gridEmployees.DataSource = bsEmployees;
            bsTransactions.DataSource = null;

        }
        private void TransactionF_Load(object sender, EventArgs e) {
            Setup();
        }



        private void btnOrder_Click(object sender, EventArgs e) {
            
        }
    }
}
