using FuelStation.Model;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Services {


    //TODO: Make it work //basic WIP for authorization handling based on given analysis.
    public class AuthorizationHandler {
        public bool HasAccessToItems(LoginStatus loginStatus) {
            if (loginStatus.LoggedIn) { 
            if (loginStatus.EmployeeType == EmployeeType.Staff ||
               loginStatus.EmployeeType == EmployeeType.Manager) {
                return true;
            }
            }
            return false;
        }
        public bool HasAccessToCustomers(LoginStatus loginStatus) {
            if (loginStatus.LoggedIn) { 
            if (loginStatus.EmployeeType == EmployeeType.Manager ||
                loginStatus.EmployeeType == EmployeeType.Cashier) {
                return true;
            }
            }
            return false;
        }
        public bool HasAccessToEmployees(LoginStatus loginStatus) {
            if (loginStatus.EmployeeType == EmployeeType.Manager && loginStatus.LoggedIn) {
                return true;
            }
            return false;
        }
        public bool HasAccessToTransactions(LoginStatus loginStatus) {
            if (loginStatus.LoggedIn) { 
            if (loginStatus.EmployeeType == EmployeeType.Manager ||
                loginStatus.EmployeeType == EmployeeType.Cashier) {
                return true;
            } }
            return false;
        }
        public bool HasAccessToLedger(LoginStatus loginStatus) {
            if (loginStatus.EmployeeType == EmployeeType.Manager && loginStatus.LoggedIn) {
                return true;
            }
            return false;
        }
    }
}
