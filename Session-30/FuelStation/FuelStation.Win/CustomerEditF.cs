using DevExpress.PivotGrid.OLAP.Mdx;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class CustomerEditF : Form {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        private CustomerViewModel _customerViewModel;
        private CustomerListViewModel _customerListViewmodel;
        public CustomerViewModel resultCustomer = new();
        public CustomerEditF(CustomerListViewModel customerListViewModel) { 
            _customerListViewmodel = customerListViewModel;
            _customerViewModel = new();

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CustomerEditF_Load(object sender, EventArgs e) {
            SetUpBindings();
        }
        private async Task  SetUpBindings() {
            if (_customerListViewmodel != null) { 
            if(_customerListViewmodel.ID != null) {
                    try { 
                    
            _customerViewModel = await httpClient.GetFromJsonAsync<CustomerViewModel>($"customer/{_customerListViewmodel.ID}");
                    txtName.Text = _customerViewModel.Name;
                    txtSurname.Text = _customerViewModel.Surname;
                    txtCardNumber.ReadOnly = true;
                    txtCardNumber.Text = _customerViewModel.CardNumber;
                    UpdateBindings();
                    }catch(Exception e) {
                        MessageBox.Show(e.Message);
                    }
            }
            }
        }
        private void UpdateBindings() {
            txtName.Refresh();
            txtSurname.Refresh();
            txtCardNumber.Refresh();
        }



        private void btnNewCard_Click(object sender, EventArgs e) {
            GenerateCardNumber();
            txtCardNumber.Refresh();
        }
       

        private async void btnAdd_Click(object sender, EventArgs e) {
            _customerViewModel.Name = txtName.Text;
            _customerViewModel.Surname = txtSurname.Text;
            _customerViewModel.CardNumber = txtCardNumber.Text;
            HttpResponseMessage response;
            try { 
            if (_customerViewModel.ID == Guid.Empty || _customerViewModel.ID == null) {
               response = await httpClient.PostAsJsonAsync("customer", _customerViewModel);
            }
            else {
                response = await httpClient.PutAsJsonAsync("customer", _customerViewModel);
            }
                if ((int)response.StatusCode == 406) { MessageBox.Show( "Error At Validating Customer Data.\nPlease Ensure the format is correct."); }
                else if ((int)response.StatusCode == 200) { MessageBox.Show("Success"); this.Close(); }
                else { MessageBox.Show( "Unexpected Error. Please try again."); }
            }
            catch (Exception) {
                MessageBox.Show("Unexpected Error. Please try again.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void GenerateCardNumber() {
            if (_customerViewModel.ID == Guid.Empty) {
                string guidString = Guid.NewGuid().ToString().Replace("-", "");
                guidString = "A" + guidString;

                if (guidString.Length > 20) {
                    guidString = guidString.Substring(0, 20);
                }
                txtCardNumber.Text = guidString;
            }
            else { MessageBox.Show("Customer Already Has a Card!"); }
        }

        private void CustomerEditF_FormClosed(object sender, FormClosedEventArgs e) {
            this.resultCustomer = _customerViewModel;
           
        }
    }
}
