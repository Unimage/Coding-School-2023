namespace CoffeeShop.MVC.Models.TransactionLine {
    public class TransactionLineDto {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public CoffeeShop.Model.Transaction Transaction { get; set; } = null!;

        public int ProductId { get; set; }
        public CoffeeShop.Model.Product Product { get; set; } = null!;
    }
}
