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
//TODO:Finish it when ive made a get by id on transrepo and and translinerepo.

namespace FuelStation.Win {
    
    public partial class SelectedTransactionDetailsF : Form {
        public TransactionListViewModel _trans = new();
        public SelectedTransactionDetailsF(TransactionListViewModel incoming) {
            _trans  = incoming;
            InitializeComponent();
        }


        public void SetUp() {
            bsTransLines.DataSource = _trans.TransLines;
            grvTransLines.DataSource = bsTransLines;
        }

        private void SelectedTransactionDetailsF_Load(object sender, EventArgs e) {
            SetUp();
        }
    }
}
