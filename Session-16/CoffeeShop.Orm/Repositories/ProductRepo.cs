using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories {
    public class ProductRepo : IEntityRepo<Product> {
        public void Create(Product entity) {
            using var context = new ApplicationDBContext();
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new ApplicationDBContext();
            var foundTodo = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundTodo is null)
                return;
            context.Products.Remove(foundTodo);
            context.SaveChanges();
        }

        public List<Product> GetAll() {
            using var context = new ApplicationDBContext();
            return context.Products.ToList();
        }

        public Product? GetById(Guid id) {
            using var context = new ApplicationDBContext();
            return context.Products.Where(prod => prod.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Product entity) {
            using var context = new ApplicationDBContext();
            var foundProduct = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundProduct is null)
                return;
            foundProduct.Cost = entity.Cost;
            foundProduct.Code = entity.Code;
            foundProduct.Price = entity.Price;
            foundProduct.Description = entity.Description;
            foundProduct.ProductCategory = entity.ProductCategory;
            context.SaveChanges();
        }
    }
}
