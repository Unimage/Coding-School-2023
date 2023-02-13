using CoffeeShop.Model.Enums;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Models.Transaction {
    public class TransactionCreateDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();

        public int EmployeeId { get; set; }
        public List<SelectListItem> Employees { get; set; } = new List<SelectListItem>();
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
