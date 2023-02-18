using FuelStation.Model;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Services {

    //basic WIP for authorization handling based on given analysis.
    //TODO: Make it work 
    public class AuthorizationHandler {

        public bool HasAccessToItems(Employee employee) {
            if (employee.EmployeeType == EmployeeType.Staff ||
               employee.EmployeeType == EmployeeType.Manager) {
                return true;
            }
            return false;
        }

        public bool HasAccessToCustomers(Employee employee) {
            if (employee.EmployeeType == EmployeeType.Manager ||
                employee.EmployeeType == EmployeeType.Cashier) {
                return true;
            }
            return false;
        }
        public bool HasAccessToEmployees(Employee employee) {
            if (employee.EmployeeType == EmployeeType.Manager) {
                return true;
            }
            return false;
        }
        public bool HasAccessToTransactions(Employee employee) {
            if (employee.EmployeeType == EmployeeType.Manager ||
                employee.EmployeeType == EmployeeType.Cashier) {
                return true;
            }
            return false;
        }
        public bool HasAccessToLedger(Employee employee) {
            if (employee.EmployeeType == EmployeeType.Manager) {
                return true;
            }
            return false;
        }
    }
}
