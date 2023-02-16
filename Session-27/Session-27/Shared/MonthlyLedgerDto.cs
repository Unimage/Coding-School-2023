using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared {
    public class MonthlyLedgerDto {

        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }


        // Relations
        public List<Manager> Managers { get; set; } = new List<Manager>();
        public List<Engineer> Engineers { get; set; } = new List<Engineer>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}