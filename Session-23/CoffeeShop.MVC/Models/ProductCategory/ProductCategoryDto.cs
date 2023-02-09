using CoffeeShop.Model.Enums;
using CoffeeShop.Model;

namespace CoffeeShop.MVC.Models.ProductCategory {
    public class ProductCategoryDto {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
