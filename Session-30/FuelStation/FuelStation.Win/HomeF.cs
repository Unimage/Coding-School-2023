using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class HomeF : Form {
        private LoginStatus _loginStatus;
        private AuthorizationHandler _authHandler = new AuthorizationHandler();
        public LoginF ToLogin { get; set; }
        public HomeF(LoginStatus loginStatus) {
            _loginStatus = loginStatus;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            HandleAccess();
        }
        
        private void HandleAccess() {
            if (_authHandler.HasAccessToCustomers(_loginStatus)) btnCustomer.Visible = true;
            if (_authHandler.HasAccessToItems(_loginStatus)) btnItem.Visible = true;
            if (_authHandler.HasAccessToTransactions(_loginStatus)) btnTransactions.Visible = true;
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            var customerListF = new CustomerListF();
            customerListF.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            _loginStatus = null;
            this.Close();

        }

        private void btnItem_Click(object sender, EventArgs e) {
            var itemListF = new ItemListF();
            itemListF.Show();

        }
    }
}
