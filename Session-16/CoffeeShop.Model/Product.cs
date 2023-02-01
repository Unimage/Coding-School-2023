using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    [Serializable]
    public class Product:BaseEntity
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        
        public List<TransactionLine> TransactionLines { get; set; } = new();
        public Product()
        {
            ID = Guid.NewGuid();
        }
    }
}


