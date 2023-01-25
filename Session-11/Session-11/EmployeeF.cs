using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11 {
    public partial class EmployeeF : Form {
        CoffeeShopHandler ShopData { get; set; } = new();
        public EmployeeF(CoffeeShopHandler transfer) {
            ShopData = transfer;
            InitializeComponent();
        }

    }
}
