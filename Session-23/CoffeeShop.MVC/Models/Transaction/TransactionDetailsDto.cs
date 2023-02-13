using CoffeeShop.Model.Enums;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Models.Transaction {
    public class TransactionDetailsDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public CoffeeShop.Model.Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public CoffeeShop.Model.Employee Employee { get; set; } = null!;

        public List<CoffeeShop.Model.TransactionLine> TransactionLines { get; set; } = new List<CoffeeShop.Model.TransactionLine>();
    }
}
