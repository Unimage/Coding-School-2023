using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Transaction {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }  // part of relations too

        public Transaction() {
            ID= Guid.NewGuid();
            TransactionLines = new();
        }

        //Relations:
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
    }
}
