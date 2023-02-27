using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Services {
    public class TransactionHandler {
        public decimal _discountPercentFuel = 10.0m;


        
        public TransactionListViewModel UpdateTransaction(TransactionListViewModel transaction, List<TransactionLineViewModel> transactionLines) {
            transaction.TotalValue = transactionLines.Sum(x => x.TotalValue);
            return transaction;
        }
        public bool CanUseCreditCard(decimal TotalValue) {
            if(TotalValue < 50) { return true; }return false;


        }
        public bool CanAddFuelItem(List<TransactionLineViewModel> transactionLInes, ItemType newItemType) {
            if (newItemType == ItemType.Fuel) {
                if (transactionLInes.Where(x => x.ItemType == ItemType.Fuel).Count() > 0) return false;
            }
            return true;
        }
        private bool HasFuelDiscount(ItemType itemType, decimal netValue) {
            return itemType == ItemType.Fuel && netValue > 20.0m;
        }
        public TransactionLineViewModel AddTransactionLine(Guid transactionID, ItemListViewModel item, int quantity) {

            var netValue = quantity * item.Price;
            var discountPercent = 0.0m;


            if (HasFuelDiscount(item.ItemType, netValue)) {
                discountPercent = _discountPercentFuel;
            }

            var discountValue = netValue * discountPercent / 100;

            return new TransactionLineViewModel() {
                TransactionID = transactionID,
                ItemID = item.ID,
                ItemName = item.Description,
                ItemType = item.ItemType,
                Quantity = quantity,
                ItemPrice = item.Price,
                NetValue = netValue,
                DiscountPercent = discountPercent,
                DiscountValue = discountValue,
                TotalValue = netValue - discountValue
            };
        }

        public  TransactionListViewModel RemoveTransLine(TransactionListViewModel incoming , Guid transLineID) {
            foreach(var tr in incoming.TransLines) {
                if(tr.ID== transLineID) {
                    incoming.TotalValue = incoming.TotalValue - tr.TotalValue;
                }
            }
            return incoming;
        }

    }
}
