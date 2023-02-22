using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class LoginF : Form {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };

        private LoginStatus _loginStatus;
        private LoginViewModel login = new LoginViewModel();
        public HomeF ToHome { get; set; }
        public LoginF() {
            _loginStatus = new();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoginF_Load(object sender, EventArgs e) {
            bsLogin.DataSource = login;
            btnCashier.Visible = false;
            btnStaff.Visible = false;
            btnManager.Visible = false;
            // TODO:Remove em completelly but for now keep em at false

        }

        private void btnStaff_Click(object sender, EventArgs e) {
            _loginStatus.EmployeeType = EmployeeType.Staff;
            _loginStatus.LoggedIn = true;
            ToHome = new(_loginStatus);
            ToHome.Show();

        }

        private void btnCashier_Click(object sender, EventArgs e) {
            _loginStatus.EmployeeType = EmployeeType.Cashier;
            _loginStatus.LoggedIn = true;
            ToHome = new(_loginStatus);
            ToHome.Show();
        }

        private void btnManager_Click(object sender, EventArgs e) {
            _loginStatus.EmployeeType = EmployeeType.Manager;
            _loginStatus.LoggedIn = true;
            ToHome = new(_loginStatus);
            ToHome.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            login.Username = txtUsername.Text;
            login.Password = txtPassword.Text;
            HandleValidSubmit();


        }
        private async void HandleValidSubmit() {
            var verifiedEmployee = await httpClient.GetFromJsonAsync<VerifiedEmployeeViewModel>($"login/{(login.Username)}/{login.Password}");

            if (verifiedEmployee is not null) {
                if (verifiedEmployee.Username is not null) {
                    _loginStatus.LoggedIn = true;
                    _loginStatus.EmployeeType = verifiedEmployee.EmployeeType;
                    ToHome = new(_loginStatus);
                    ToHome.Show();
                }
            }
            else { MessageBox.Show("alert", "Wrong Credentials."); }
        }
    }
}
