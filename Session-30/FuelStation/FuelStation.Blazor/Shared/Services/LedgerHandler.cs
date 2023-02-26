using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.Services {
    public class LedgerHandler {
        private int _year;
        private int _month;
        public List<Employee> _employees = new List<Employee>();
        public List<Transaction> _transactions = new List<Transaction>();
        public List<Item> _items = new List<Item>();



        public LedgerHandler() {
        }

        public List<Transaction> GetSelectedMonthTransactions(DateTime date) {
            _month = date.Month;
            _year= date.Year;
            return _transactions.Where(x=>x.Date.Month == _month && x.Date.Year == _year).ToList();
        }
        public decimal CalculateSelecteMonthIncomeFromTransactions(List<Transaction> _monthTransactions) {
             decimal Totalincome = 0;
            foreach(var tr in _monthTransactions) {
                Totalincome += tr.TotalValue;
            }
            return Totalincome;
        }
        public decimal CalculateSelectedMonthExpensesFromTransactions(List<Transaction> _monthTransactions) {
            decimal TotalTransactionExpenses = 0;
            foreach(var tr in _monthTransactions) {
                foreach (var trl in tr.TransactionLines) {
                    TotalTransactionExpenses += trl.Item.Cost * trl.Quantity;
                }
            }
            return TotalTransactionExpenses;
        }

        public List<Employee> GetMonthCurrentWorkingEmployees(DateTime date) {
            _month = date.Month;
            _year = date.Year;
            return _employees.Where(x => ((x.HireDateStart.Year < _year) || (x.HireDateStart.Year == _year && x.HireDateStart.Month <= _month)) &&
                                        (x.HireDateEnd == null ||((x.HireDateEnd.Value.Year == _year && x.HireDateEnd.Value.Month >= _month) ||
                                        (x.HireDateEnd.Value.Year > _year))))
                .ToList();
        }
        public decimal CalculateSelectedMonthExpensesFromEmployees(List<Employee> _monthEmployees) {
            decimal totalEmployeeCost = 0;
            foreach(var emp in _monthEmployees) {
                totalEmployeeCost += emp.SallaryPerMonth;
            }
            return totalEmployeeCost;
         
        }
        public LedgerViewModel CreateLedger(int year, int month) {
            DateTime tmp = new DateTime(year, month, 1);
            return new LedgerViewModel {
                Date = tmp,
            Expenses = CalculateSelectedMonthExpensesFromEmployees(GetMonthCurrentWorkingEmployees(tmp)) + CalculateSelectedMonthExpensesFromTransactions(GetSelectedMonthTransactions(tmp)) + 5000,
                Income = CalculateSelecteMonthIncomeFromTransactions(GetSelectedMonthTransactions(tmp)),
                Total = CalculateSelecteMonthIncomeFromTransactions(GetSelectedMonthTransactions(tmp)) - CalculateSelectedMonthExpensesFromEmployees(GetMonthCurrentWorkingEmployees(tmp)) - CalculateSelectedMonthExpensesFromTransactions(GetSelectedMonthTransactions(tmp)) - 5000
            };
        }

    }
}
