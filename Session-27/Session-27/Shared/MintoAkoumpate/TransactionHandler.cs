using Microsoft.EntityFrameworkCore.Query.Internal;
using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared.MintoAkoumpate {
    public class TransactionHandler {
        private decimal _workhour = 44.5m;
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
        public bool ValidateInsertTransactionLine(Transaction trans, TransactionLineEditDto transLine) {
            if ((trans.TransactionLines.FindAll(x => x.ServiceTaskId == transLine.ServiceTaskId).Count == 0 &&
                trans.TransactionLines.FindAll(x => x.EngineerId == transLine.EngineerId).Count == 0)) {
                return true;
            }
            return false;
        }
        public bool ValidateUpdateTransactionLine(Transaction trans, TransactionLineEditDto transLine) {
            if ((trans.TransactionLines.FindAll(x => x.ServiceTaskId == transLine.ServiceTaskId &&x.Id!=transLine.Id).Count == 0 &&
                trans.TransactionLines.FindAll(x => x.EngineerId == transLine.EngineerId && x.Id != transLine.Id).Count == 0 )) {
                return true;
            }
            return false;
        }
        public decimal CalculateTotalCost(Transaction transaction) {

            decimal totalCost = 0;
            foreach(var trl in transaction.TransactionLines) {
                totalCost += trl.ServiceTask.Hours * _workhour;
            }
            return totalCost;
        }

        public bool ValidateMaxWorkLoad(Transaction transaction, TransactionLine transLine, int engineerAmount)
        {
            int MaxWorkLoad = engineerAmount * 8;
            decimal currentWorkLoad = 0;
            decimal tmp = 0;
            foreach (var trl in transaction.TransactionLines)
            {
                currentWorkLoad += trl.ServiceTask.Hours;
            }
            if (currentWorkLoad + transLine.Hours <MaxWorkLoad) {
                return true;
            }
            return false;
        }


    }
}
