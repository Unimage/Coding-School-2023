using CoffeeShop.Model;
using CoffeeShop.Orm.Repositories;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
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
    public partial class EmployeeF : XtraForm {
        
        CoffeeShopHandler ShopData { get; set; } = new();
        public EmployeeRepo employeeRepo = new EmployeeRepo();
        public EmployeeF(CoffeeShopHandler transfer) {
            ShopData = transfer;
            InitializeComponent();
            bsEmployees.DataSource = employeeRepo.GetAll();
            gcEmployee.DataSource = bsEmployees;
        }
        private void btnRefreshList_Click(object sender, EventArgs e) {
            gcEmployee.DataSource = null;
            gcEmployee.DataSource = ShopData.Employees;
        }
        private void ResetGVs() {
            bsEmployees.DataSource = null;
            bsEmployees.DataSource = employeeRepo.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            try {
                ShopData.Employees = employeeRepo.GetAll();
                Employee emp = new Employee();
                if (tboxName.Text != null && tboxSurname.Text != null && tboxSalary.Text != null && comboRole.SelectedItem != null) {
                    Employee tmpEmp = new Employee() {
                        Name = tboxName.Text,
                        Surname = tboxSurname.Text,
                        EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), comboRole.SelectedItem.ToString()),
                        Salary = Convert.ToDecimal(tboxSalary.Text)
                    };
                    ShopData.Employees.Add(tmpEmp);
                    if (!ShopData.CheckStaffLimits()) {
                        employeeRepo.Create(tmpEmp);
                        MessageBox.Show("New Employee Successfully added to Roster!\nPress Reload To See.");
                        ResetGVs();
                    }
                    else {
                        MessageBox.Show("Staff Limit Error. Check Shop's Limits and try again.");
                        ResetGVs();
                    }
                }
                else { 
                    MessageBox.Show("Cant Instert without imputs Please Fill em all!"); 
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Cant Instert without imputs");
            }
        }

        private void btnFetch_Click(object sender, EventArgs e) {
            ResetGVs();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            ShopData.Employees= employeeRepo.GetAll();
            var item = bsEmployees.Current as Employee;
            if (item is null)
                return;
            
            ShopData.Employees.Remove(item);
            if(!ShopData.CheckStaffLimits()) {
                employeeRepo.Delete(item.ID);
                MessageBox.Show("Stuff Limits are okay.\nStaff Memeber deleted");
            }
            else {
                MessageBox.Show("Error!.Cant Delete Staff Member\nPlease check staff limits.");
            }
            ResetGVs();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            ShopData.Employees = employeeRepo.GetAll();
            var item = bsEmployees.Current as Employee;
            if (item is null)
                return;
            ShopData.Employees.Remove(item);
            ShopData.Employees.Add(item);
            if (!ShopData.CheckStaffLimits()) {
                employeeRepo.Update(item.ID, item);
                MessageBox.Show("Stuff Limits are okay.\nSelected Staff Memeber info has been updated");
            }
            else {
                MessageBox.Show("Error!Cant change Role of Staff Member\nPlease check staff limits.");
            }
            ResetGVs();

        }
    }
}
