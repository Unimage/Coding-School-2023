using FuelStation.Model;
using FuelStation.Model.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared.ViewModels {
    public class TransactionListViewModel {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public Guid CustomerID { get; set; }
        public string? CustomerCardNumber { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
