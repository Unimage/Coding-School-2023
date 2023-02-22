using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class LoginF : Form {
        private LoginStatus _loginStatus;
        private LoginViewModel login = new LoginViewModel();
        public HomeF ToHome { get; set; } 
        public LoginF() {
            _loginStatus = new();
            InitializeComponent();
        }
        private void LoginF_Load(object sender, EventArgs e) {
            bsLogin.DataSource = login;
            // SetDataBindings();

        }
        private void SetDataBindings() {
            txtUsername.DataBindings.Add(new Binding("EditValue", bsLogin, "Username", true));
            txtPassword.DataBindings.Add(new Binding("EditValue", bsLogin, "Password", true));
        }

        private void btnStaff_Click(object sender, EventArgs e) {
            _loginStatus.EmployeeType = EmployeeType.Staff;
            _loginStatus.LoggedIn= true;
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
    }
}
