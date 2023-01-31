﻿using CoffeeShop.Model;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    [Serializable]
    public class ProductCategory:BaseEntity
    {
        
        public Guid ProductCategoryID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ProductType ProductType { get; set; }
        public Product Product { get; set; }


        public ProductCategory()
        {
            ProductCategoryID = Guid.NewGuid();
        }

    }
}