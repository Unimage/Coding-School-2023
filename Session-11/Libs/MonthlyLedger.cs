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
        public List<Double> Expenses { get; set; }

        public Double Total { get; set; }    // Income - Expenses


        




        MonthlyLedger(System.DateTime dateTime ) {
        
            Year = dateTime.Year; // get the Year out of System Date 
            Month = dateTime.Month; 

            // maybe initialize the Lists here


        
        } 











    }
}
