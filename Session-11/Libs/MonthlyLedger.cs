using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs {

    //TODO:Discuss and implement ledger 
    public class MonthlyLedger {

        public int Year  { get; set; }
        public int Month { get; set; }

        public List<Double> Income { get; set; } 
        public List<Double> Expense { get; set; }

        public Double Total { get; set; }    // Income - Expense 


        






    }
}
