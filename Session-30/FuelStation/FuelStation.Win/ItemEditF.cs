using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model.Enumerations;
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
using System.Xml.Linq;

namespace FuelStation.Win {
    //TODO:Change on edit so it takes current ItemType when editing an existing Item instead of a default.
    public partial class ItemEditF : Form {
        private readonly HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
            BaseAddress = new Uri("https://localhost:7026")
        };
        private ItemViewModel _itemViewModel;
        private ItemListViewModel _itemListViewmodel;
        public ItemEditF(ItemListViewModel itemListViewModel) {
            _itemListViewmodel = itemListViewModel;
            _itemViewModel = new();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ItemEditF_Load(object sender, EventArgs e) {
            SetUpBindings();
        }
        private async Task SetUpBindings() {
            if (_itemListViewmodel != null) {
                if (_itemListViewmodel.ID != null) {
                    try {

                        _itemViewModel = await httpClient.GetFromJsonAsync<ItemViewModel>($"item/{_itemListViewmodel.ID}");
                        txtCode.Text = _itemViewModel.Code;
                        txtDescription.Text = _itemViewModel.Description;
                        txtCost.Text = _itemViewModel.Cost.ToString();
                        txtPrice.Text = _itemViewModel.Price.ToString();
                        cboxItemType.DataSource = Enum.GetValues(typeof(ItemType));

                        UpdateBindings();
                    }
                    catch (Exception e) {
                        MessageBox.Show(e.Message);
                    }
                }

            }

        }
        private void UpdateBindings() {
            txtCode.Refresh();
            txtDescription.Refresh();
            txtCost.Refresh();
            txtPrice.Refresh();
            cboxItemType.Refresh();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private async void btnAdd_Click(object sender, EventArgs e) {
            _itemViewModel.Code = txtCode.Text;
            _itemViewModel.Description = txtDescription.Text;
            _itemViewModel.Price = decimal.Parse(txtPrice.Text);
            _itemViewModel.Cost = decimal.Parse(txtCost.Text);
            _itemViewModel.ItemType = (ItemType)Enum.Parse(typeof(ItemType), cboxItemType.SelectedItem.ToString());


            HttpResponseMessage response;
            try {
                if (_itemViewModel.ID == Guid.Empty || _itemViewModel.ID == null) {
                    response = await httpClient.PostAsJsonAsync("item", _itemViewModel);
                }
                else {
                    response = await httpClient.PutAsJsonAsync("item", _itemViewModel);
                }
                if ((int)response.StatusCode == 406) { MessageBox.Show("Error At Validating Item Data.\nPlease Ensure the format is correct."); }
                else if ((int)response.StatusCode == 200) { MessageBox.Show("Success"); this.Close(); }
                else { MessageBox.Show("Unexpected Error. Please try again."); }
            }
            catch (Exception) {
                MessageBox.Show("Unexpected Error. Please try again.");
            }
        }
    }
}
