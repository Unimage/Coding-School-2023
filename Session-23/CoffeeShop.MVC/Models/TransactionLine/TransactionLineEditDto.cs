using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Models.TransactionLine {
    public class TransactionLineEditDto {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public List<SelectListItem> Products { get; set; } = new List<SelectListItem>();

        public int ProductId { get; set; }
        public List<SelectListItem> Transactions { get; set; } = new List<SelectListItem>();
    }
}
