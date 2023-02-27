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
    public partial class ItemListF : Form {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        private List<ItemListViewModel> itemList = new();
        public ItemListF() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public async Task SetUpBindings() {
            itemList = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
            grdItems.AutoGenerateColumns = false;
            bsItems.DataSource = itemList;
            grdItems.DataSource = bsItems;
        }

        private void ItemListF_Load(object sender, EventArgs e) {
            try {
                SetUpBindings();
            }
            catch (Exception ex) {
                MessageBox.Show(this, $"Error retrieving Data from database.\n[{ex}]",
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            CallEdit(null);
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            if (bsItems.Current is ItemListViewModel item) {
                CallEdit(item);
            }
        }
        private void CallEdit(ItemListViewModel? item) {
            if (item is null) {
                item = new ItemListViewModel();
                item.ID = Guid.Empty;
            }
            var itemEditForm = new ItemEditF(item);
            itemEditForm.ShowDialog();
            if (itemEditForm.DialogResult == DialogResult.OK || itemEditForm.DialogResult == DialogResult.Abort || itemEditForm.DialogResult == DialogResult.Cancel) {
                SetUpBindings();
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e) {
            if (bsItems.Current is ItemListViewModel item) {
                DialogResult result = MessageBox.Show("Delete selected Customer?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    var response = await httpClient.DeleteAsync($"item/{item.ID}");
                    if ((int)response.StatusCode != 200) { MessageBox.Show("Error At Deleting Customer.\nCustomer is tied to a List of Transactions."); }
                    SetUpBindings();
                }
                else { SetUpBindings(); }
            }
        }
    }
}
