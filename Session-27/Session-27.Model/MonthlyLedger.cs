using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Model {

    public class MonthlyLedger {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }


        // Relations
        public List<Transaction> Transactions { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<Manager> Managers { get; set; }

        public MonthlyLedger() {

        }
        public MonthlyLedger(int year ,int month ) {
            Year = year;
            Month = month;
            Income = 0;
            Expenses = 0;
            Total = 0;
        }
    }
}
