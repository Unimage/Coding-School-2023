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
using Session_11;

namespace Libs {

    //TODO:Discuss and implement ledger 
    public class MonthlyLedger {

        private int _rentExpense = 0;
        private decimal globalIncome = 0;
        private decimal globalExpenses = 0;


        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }    

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }

        public List<Transaction> Transactions { get; set; }

        public List<Employee> Employees { get; set; }

        public List<Product> Products { get; set; }




        // 








        MonthlyLedger()
        {
            this.Year= DateTime.Now.Year;
            this.Month= DateTime.Now.Month;
            this.Income = CalculateTransactionSum(Transactions);
            this.Expenses = CalculateEmployeeCost(Employees) + CalculateProductCost(Products);
            this.Total = (Income - Expenses);

           

        }

        // NET INCOME 
        public decimal CalculateTransactionSum(List<Transaction> transactions)
        {
            // L
            // decimal sumOfTransactions = transactions.Sum(transaction => transaction.TotalPrice);
            decimal sumOfTransactions = 0;

            foreach (Transaction transaction in transactions)
            {

                sumOfTransactions += transaction.TotalPrice;
            }

            return sumOfTransactions;

        }

        // EXPENSES
        public decimal CalculateEmployeeCost(List<Employee> employees) 
        
        {
        
           decimal totalEmpCost = 0;

            foreach (Employee employee in employees) {
                totalEmpCost +=  employee.Salary;    
            }
        
            return totalEmpCost;
        }


        //EXPENSES 
        public decimal CalculateProductCost(Transaction trans)
        {
            decimal totalProductCost = 0;
            foreach (var tr in trans.TransactionLines) {
                totalProductCost += tr.Quantity * tr.Product.Cost;   // auto ennousa san allagi

            }
            return totalProductCost;
        }

        //TODO calculate the balance  out of INCOME / Expenses / TOTAL 
       

    }
}
