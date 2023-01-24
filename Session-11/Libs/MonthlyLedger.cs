using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;
using System.Numerics;

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


        


        // File Operations - DeSerializer 

        public void InitLedger (DateTime dateTime)
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
                    
                    
                    var ledger = JsonConvert.DeserializeObject<List<Transaction>>(json);

                    if ( ledger != null) {
                        
                        
                       decimal total =   CalculateTransactionSum( ledger );

                      //  decimal expenses = CalculateBalance();
                       decimal balance = CalculateBalance(total, expenses);
                        
                        
                    }
                  } catch (Exception e)
                {
                    exceptionLogger.Log(e.ToString());
                }

                   
                

                
            }
        }




        // Not in final form 
        // TODO decide the final implementation of Calculating the balance 
        public decimal  CalculateBalance(decimal income, decimal expenses) {
        
            

            
            

            return ((income-expenses) - _rentExpense);
        

        
        }



        public decimal CalculateTransactionSum(List<Transaction> transactions)
        {
            // L
           decimal sumOfTotals = transactions.Sum(transaction => transaction.TotalPrice);

            return sumOfTotals;

        }

        public decimal CalculateEmployeeCost(List<Employee> employees , List<Transaction> transactions) 
        
        {
        
           decimal totalEmpCost = 0;

            foreach (Employee employee in employees) {
                totalEmpCost +=  employee.Salary;    
            }
        
            return totalEmpCost;
        }


    }
}
