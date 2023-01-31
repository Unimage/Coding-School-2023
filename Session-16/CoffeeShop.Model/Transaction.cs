using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    [Serializable]
    public class Transaction:BaseEntity
    {
        public Guid ID { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalCost { get; set; }
        public Employee Employee { get; set; }



        public Transaction()
        {
            ID= Guid.NewGuid();
            TransactionLines= new List<TransactionLine>();

        }
        public Transaction( DateTime date, Guid customerID, Guid employeeID)
        {
            Date = date;
            CustomerID = customerID;
            EmployeeID = employeeID;
            TransactionLines = new List<TransactionLine>();
        }   
    }
}
