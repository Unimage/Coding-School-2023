using FuelStation.Blazor.Shared.ViewModels;
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
    public partial class TransactionInfoF : Form {
        private Guid transId;
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        private TransactionListViewModel _transaction = new();
        public TransactionInfoF(Guid transID) {
            transId = transID;
            InitializeComponent();
        }
        public async void Setup() {
            _transaction = await httpClient.GetFromJsonAsync<TransactionListViewModel>($"transaction/{transId}");
            grvTransLines.AutoGenerateColumns = false;
            bsTransLines.DataSource = _transaction.TransLines;
            grvTransLines.DataSource = bsTransLines;
        }

        private void TransactionInfoF_Load(object sender, EventArgs e) {
            Setup();
        }
    }
}