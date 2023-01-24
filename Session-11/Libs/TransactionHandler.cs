using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Summary
///TransactionHandler will be the instance we call that does all the basic processes
///here will do produc calculations , discount 
///remove or add discoun , check payment method 
///update and possuibly export a json
///Later in the implementation it will have a role of housekeeping ledger 
///

namespace Libs {
    internal class TransactionHandler 
    {
        public Transaction _transaction;
        public TransactionLine _transactionLine;

        private decimal _discountPercent = 0.15;
        private decimal _discountThreshold = 10;
        public Transaction Trans { get; set; } = new(); 
        public TransactionLine  TransLine { get; set; } = new();

        public void AddTransactionLines(TransactionLine line) 
        {
            _transaction.TransactionLines.Add(line) ;
        }

       public void CalculateTransaction() 
        {
            decimal total= 0 ;
            foreach(var line in _transaction.TransactionLines) 
            {
                line.TotalPrice = line.Price * line.Quantity;
                total += line.TotalPrice;
            }
            _transaction.TotalPrice = total;
            ApplyDiscount();
        }

      
        public decimal ApplyDiscount() 
        {
            if (_transaction.TotalPrice >= 50) 
            {
                _transaction.TotalPrice = _transaction.TotalPrice -(_transaction.TotalPrice *0.15m);
            }
        }
        
        public void ChangeLineQuantity(int id, int newQuantity)
        {
            var line= _transaction.TransactionLines.Find(x => x.Id == id);
            if (line != null)
            {
                line.Quantity = newQuantity;
                CalculateTransaction();
            }
        }
        public void RemoveTransactionLine (int id)
        {
            var line = _transaction.TransactionLines.Find(x => x.ID == id);
            if (line!= null)
            {
                _transaction.TransactionLines.Remove(line);
                CalculateTransaction();
            }
        }    
        public void SaveTransactionToJson()
        {
            string json = JsonConvert.SerializeObject(_transaction);
            string path = $"reciept{_transaction.ID}.json";
            File.WriteALLText(path, json);
        }
        public string FinalizeTrasaction()
        {
            if(_transaction==null)
            {
                return "nothing to checkout";
            }
            if (_transaction.PaymentMethod == PaymentMethod.CreditCard&&_transaction.TotalPrice >= 50)
            {
                return "can only pay with cash";
            }
            SaveTransactionToJson();
            return $"The total amount is {_transaction.TotalPrice}";
        }


    }    
}

/*
 * Business : 
 * initially on the form we want the menu to display things to add to the cart. Each time u pick an option eg.(espresso) and quantiny x3.
 * After Accept the form creates and sends the coresponding 
*/