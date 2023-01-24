using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace Libs {

    //TODO:Discuss and implement ledger 
    public class MonthlyLedger {

        private int _rentExpense = 3000;
        private decimal globalIncome = 0;
        private decimal globalExpenses = 0;


        public Double Balance { get; set; }    // Income - Expenses

        

        public Double Balance { get; set; }    // Income - Expenses


        

        MonthlyLedger(System.DateTime dateTime , double initialExpense ) {

              
        
            Year = dateTime.Year; // get the Year out of System Date 
            Month = dateTime.Month; 

        
        }


        


        // -- Initialize the ledger 

        public void InitLedger (DateTime dateTime , List<Employee> employees)
        {
            ExceptionLogger exceptionLogger = new ExceptionLogger(System.DateTime.Now);

            string ledgerFile = ($"monthly_ledger_{dateTime.Year}_{dateTime.Month}.json");
            if (!File.Exists( ledgerFile )) 
               
            {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(ledgerFile))
                    {

                    }

                } catch(Exception e)
                {

                    // record the exception to the ExceptionLogger
                    
                    exceptionLogger.Log(e.ToString());


                }
            }
              else
            {
                try
                {
                    string json = File.ReadAllText( ledgerFile );
                    // using NewtonSoft package for Json
                    var ledger = Newtonsoft.Json.JsonConvert.DeserializeObject<MonthlyLedger>(json);

                    if ( ledger != null) {
                        MonthlyLedger monthlyLedger = ledger;
                        return monthlyLedger;
                    }
                  } catch (Exception e)
                {
                    exceptionLogger.Log(e.ToString());
                }

                   
                

                
            }
        }

















        // Not in final form 
        // TODO decide the final implementation of Calculating the balance 
        public decimal  CalculateBalanced(decimal income, decimal expenses) {
        
            

            
            // this.Total = incomeTotal - expensesTotal;  

            return ((income-expenses) - _rentExpense);
        

        
        }




    }
}
