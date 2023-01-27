using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///CoffeeShopWrapper is gonna be the Kind of promise we made so
///So the programm doesnt save 5 files individually but one single.
///Since we cant chage the whole architecture wrappes is gonna be used on main
/// </summary>

namespace Libs {
    [Serializable]
    public  class CoffeeShopWrapper {
        CoffeeShopHandler CoffeeData { get; set; }
        TransactionHandler Transaction { get; set; }
        MonthlyLedger Ledger { get; set; }

        public CoffeeShopWrapper() { }
        public CoffeeShopWrapper(CoffeeShopHandler coffeeData, TransactionHandler transaction , MonthlyLedger ledger){
            this.CoffeeData = new CoffeeShopHandler();
            this.Ledger = new MonthlyLedger();
            this.Transaction = new TransactionHandler();
            this.CoffeeData = coffeeData;
            this.Transaction = transaction;
            this.Ledger = ledger;
        }
        


    }
}
