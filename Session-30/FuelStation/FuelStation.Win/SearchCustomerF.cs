using DevExpress.XtraSpreadsheet.Export;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class SearchCustomerF : Form {
        private LoginStatus _loginStatus;

        private List<CustomerListViewModel> customers = new List<CustomerListViewModel>();
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        public SearchCustomerF(LoginStatus loginStatus) {
            _loginStatus = loginStatus;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            customers = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
            Guid foundID = Guid.Empty;
            bool found = false;

            CustomerListViewModel foundcus = new();
            foreach (var cus in customers) {
                
                if (cus.CardNumber.ToString() == textBox1.Text.ToString()) {
                    foundcus = cus;
                    found = true;
                    break;
                }
            }
            if (found && foundcus!= null) {
                MessageBox.Show("Customer Found!\n" + foundcus.Name + " " + foundcus.Surname);
                var trForm = new TransactionDetailsF(_loginStatus.EmployeeID, foundcus.ID);
                trForm.ShowDialog();
            }
            else {
                MessageBox.Show("Customer not Found!\n");
                var form = new CustomerEditF(null);
                form.ShowDialog();
                customers = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
                var trForm = new TransactionDetailsF(_loginStatus.EmployeeID, customers.Where(c => c.CardNumber == form.resultCustomer.CardNumber).Select(c => c.ID).SingleOrDefault());
                trForm.ShowDialog();
            }
        }
    }
}
