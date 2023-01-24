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

        public Double Balance { get; set; }    // Income - Expenses


        




        MonthlyLedger(System.DateTime dateTime , double initialExpense ) {

              
        
            Year = dateTime.Year; // get the Year out of System Date 
            Month = dateTime.Month; 

           


        
        } 


        public void AddToIncome(double income)
        {
            Income.Add( income );
        }


        public void AddToExpenses(double expenses)
        {
            Expenses.Add( expenses );
        }













        // Not in final form 
        // TODO decide the final implementation of Calculating the balance 
        public double CalculateBalance(List<Double> income , List<Double> expenses) {
        
            double incomeTotal = income.Sum();
            double expensesTotal = expenses.Sum();

            
            // this.Total = incomeTotal - expensesTotal;  

            return (incomeTotal - expensesTotal);
        

        
        }




    }
}
