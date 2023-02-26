using FuelStation.Blazor.Shared.ViewModels;
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
    public partial class SelectedTransactionDetailsF : Form {
        public TransactionListViewModel _trans = new();
        public SelectedTransactionDetailsF(TransactionListViewModel incoming) {
            _trans  = incoming;
            
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
    }
}
