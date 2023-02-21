using FuelStation.Blazor.Shared.Etc;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Services {
    public class DataValidator {
        private readonly Limits limits = new Limits();

        #region Employee Validations
        public bool ValidateEmployeeData(EmployeeViewModel employee) {
            return ValidatePassword(employee.password) &&
                ValidateSallary(employee.SallaryPerMonth) &&
                ValidateUsername(employee.username) &&
                CheckName(employee.Name) &&
                    CheckSurname(employee.Surname) &&
                    employee.HireDateStart != null;
        }
        public bool ValidateSallary(decimal sallary) {
            return sallary > 0 && sallary < 99999.99m;
        }
        public bool ValidateUsername(string uname) {
            if (uname != null) {
                if (uname.Length > 0 && uname.Length <= 20) {
                    return true;
                }
            }
            return false;
        }
        public bool ValidatePassword(string pass) {
            if (pass != null) {
                if (pass.Length > 0 && pass.Length <= 20) {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Customer Validations
        public bool ValidadeCustomerData(CustomerViewModel customer) {
            return (CheckName(customer.Name) &&
                CheckSurname(customer.Surname) &&
                CheckCardNumber(customer.CardNumber));
        }
        public bool CheckName(string name) {
            if (name == null) {
                return false;
            }
            if (name.Length > 1 && name.Length <= limits._maxEmpNameSize) {
                return true;
            }
            return false;
        }
        public bool CheckSurname(string surname) {
            if (surname == null) {
                return false;
            }
            if (surname.Length > 1 && surname.Length <= limits._maxSurnameSize) {
                return true;
            }
            return false;
        }
        public bool CheckCardNumber(string card) {
            if (card == null) {
                return false;
            }
            if (card.Length > 1 && card.Length <= limits._maxCardSize) {
                if (card[0] == limits._firstCardChar) {
                    return true;
                }
            }
            return false;
        }



        #endregion
        #region Item Validations
        public bool ValidateItemData(ItemViewModel item) {
            return (ValidateCode(item.Code)
                && ValidateDescription(item.Description)
                && ValidateCost(item.Cost)
                && ValidatePrice(item.Price));
        }
        public bool ValidateDescription(string description) {
            if (description != null) {
                if (description.Length > 1 && description.Length <= 30) {
                    return true;
                }
            }
            return false;
        }
        public bool ValidateCode(string code) {
            if (code != null) {
                if (code.Length > 1 && code.Length <= 6) {
                    return true;
                }
            }
            return false;
        }
        public bool ValidatePrice(decimal price) {
            if (price != null) {
                if (price > 0 && price < 99999.99m) {
                    return true;
                }
            }
            return false;
        }
        public bool ValidateCost(decimal cost) {
            if (cost != null) {
                if (cost > 0 && cost < 99999.99m) {
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Check for minus logic for roster
        public bool CheckRosterMinus(List<Employee> employeeList, EmployeeViewModel incomingEmployee) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers--;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers--;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff--;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        public bool CheckRosterMinus(List<Employee> employeeList, EmployeeListViewModel incomingEmployee) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers--;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers--;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff--;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        public bool CheckRosterMinus(List<Employee> employeeList, Employee incomingEmployee) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers--;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers--;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff--;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        #endregion
        #region Roster Check for plus logic for roster
        public bool CheckRosterPlus(List<Employee> employeeList, EmployeeListViewModel incomingEmployee) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers++;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers++;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff++;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        public bool CheckRosterPlus(List<Employee> employeeList, Employee incomingEmployee) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers++;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers++;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff++;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        public bool CheckRosterPlus(List<Employee> employeeList, EmployeeViewModel incomingEmployee) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers++;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers++;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff++;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        public bool CheckRosterPut(List<Employee> employeeList, EmployeeViewModel incomingEmployee , Employee oldOne) {
            int currentManagers = 0;
            int currentCashiers = 0;
            int currentStaff = 0;
            foreach (var emp in employeeList) {
                if (emp.HireDateEnd == null) {
                    switch (emp.EmployeeType) {
                        case Model.Enumerations.EmployeeType.Manager:
                            currentManagers++;
                            break;
                        case Model.Enumerations.EmployeeType.Cashier:
                            currentCashiers++;
                            break;
                        case Model.Enumerations.EmployeeType.Staff:
                            currentStaff++;
                            break;
                        default:
                            break;
                    }
                }
            }
            switch (incomingEmployee.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers++;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers++;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff++;
                    break;
                default:
                    break;
            }
            switch (oldOne.EmployeeType) {
                case Model.Enumerations.EmployeeType.Manager:
                    currentManagers--;
                    break;
                case Model.Enumerations.EmployeeType.Cashier:
                    currentCashiers--;
                    break;
                case Model.Enumerations.EmployeeType.Staff:
                    currentStaff--;
                    break;
                default:
                    break;
            }
            return currentManagers <= limits.MaxManagers &&
                    currentCashiers <= limits.MaxCashiers &&
                    currentStaff <= limits.MaxStaff &&
                    currentStaff >= 1 &&
                    currentManagers >= 1 &&
                    currentCashiers >= 1;
        }
        #endregion

    }
}
