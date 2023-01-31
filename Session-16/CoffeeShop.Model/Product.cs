﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    [Serializable]
    public class Product:BaseEntity
    {
        public Guid ProductID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid ProductCategoryID { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public TransactionLine TransactionLine { get; set; }
        public Product()
        {
            ProductID = Guid.NewGuid();
        }
    }
}


