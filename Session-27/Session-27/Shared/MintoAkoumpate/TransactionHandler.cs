using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared.MintoAkoumpate {
    public class TransactionHandler {
        public bool ValidateInsertTransaction(List<Transaction> transactionList, TransactionEditDto transaction) {
            if (transactionList.FindAll(x => x.CarId == transaction.CarId).Count == 0 || // checks if theres an existing transaction with customer or car inserted.
                transactionList.FindAll(x => x.CustomerId == transaction.CustomerId).Count == 0) { return true; }
            return false;
        }
        public bool ValidateUpdateTransaction(List<Transaction> transactionList, TransactionEditDto transaction) {
            if (transactionList.FindAll(x => x.CarId == transaction.CarId && transaction.Id != x.Id).Count == 0 || // checks if theres an existing transaction with customer or car inserted.
               transactionList.FindAll(x => x.CustomerId == transaction.CustomerId && transaction.Id != x.Id).Count == 0) { return true; }
                return false;
        }
    }
}
