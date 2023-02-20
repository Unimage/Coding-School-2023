using FuelStation.Blazor.Shared.Etc;
using FuelStation.Blazor.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Services {

    //Generic all in one Validator class containing all validation methods needed
    //for server side validation 
    //possibly some used in client-side / winforms 
    //TODO:WIP
    public class DataValidator {
        private readonly Limits limits = new Limits();

        #region Employee Validations


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
    }
}
