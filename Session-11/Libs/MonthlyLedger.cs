using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace Libs {

    //TODO:Discuss and implement ledger 
    public class MonthlyLedger {

        private int _rentExpense = 3000;
        private decimal globalIncome = 0;
        private decimal globalExpenses = 0;


        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Balance { get; set; }    // Income - Expenses

        public List<Transaction> Transactions { get; set; }
        public List<Employee> Employees { get; set; }








        

       


        

        MonthlyLedger(System.DateTime dateTime , double initialExpense , List<Employee> employees , List<Transaction> transactions ) {

              
        
           Year = dateTime.Year;
           Month = dateTime.Month;


        
        }


        


        // File Operations - Serializer 

        public void InitLedger (DateTime dateTime , List<Employee> employees)
        {
            ExceptionLogger exceptionLogger = new ExceptionLogger(System.DateTime.Now);

            string ledgerFile = ($"monthly_ledger_{dateTime.Year}_{dateTime.Month}.json");

            // if no json exists , create it 
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
                    var ledger = 


                    if ( ledger != null) {
                        
                        

                        return;
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
