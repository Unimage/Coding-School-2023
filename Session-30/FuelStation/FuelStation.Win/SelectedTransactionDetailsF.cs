using DevExpress.XtraReports.Parameters.ViewModels;
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
    public partial class SelectedTransactionDetailsF : Form {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        public TransactionListViewModel _trans = new();
        private readonly TransactionHandler _transactionHandler;
        public SelectedTransactionDetailsF(TransactionListViewModel incoming) {
            _trans  = incoming;
            _transactionHandler = new();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void SetUp() {
            labelTransID.Text = "Details of TransactionID: " + _trans.ID;
            grvTransLines.AutoGenerateColumns = false;
            bsTransLines.DataSource = _trans.TransLines;
            grvTransLines.DataSource = bsTransLines;
        }

        private void SelectedTransactionDetailsF_Load(object sender, EventArgs e) {
            SetUp();
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            TransactionLineViewModel selected = bsTransLines.Current as TransactionLineViewModel;
            if (selected != null) { 
               DialogResult result = MessageBox.Show("Delete selected Transaction Line?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    var response = await httpClient.DeleteAsync($"transactionLine/{selected.ID}");
                    if ((int)response.StatusCode != 200) { MessageBox.Show("Error At deleting Specified Transaction Line"); }
                    _trans =_transactionHandler.RemoveTransLine(_trans,selected.ID);
                    response = await httpClient.PutAsJsonAsync("transaction", _trans);
                    if ((int)response.StatusCode != 200) { MessageBox.Show("Error At Updating Transactions Total Value"); } else { MessageBox.Show("Transaction Line has been deleted Sucessfullu!");}
                    this.Close();
                }
                else { SetUp(); }
            }
        }
    }
}
