using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories {
    public class ProductCategoryRepo : IEntityRepo<ProductCategory> {
        public void Create(ProductCategory entity) {
            using var context = new ApplicationDBContext();
            context.ProductCategories.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new ApplicationDBContext();
            var foundProdCat = context.ProductCategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (foundProdCat is null)
                return;
            context.ProductCategories.Remove(foundProdCat);
             context.SaveChanges();
        }

        public List<ProductCategory> GetAll() {
            using var context = new ApplicationDBContext();
            return context.ProductCategories.ToList();
        }

        public ProductCategory? GetById(Guid id) {
            using var context = new ApplicationDBContext();
            return context.ProductCategories.Where(prodCat => prodCat.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, ProductCategory entity) {
            using var context = new ApplicationDBContext();
            var foundProductCat = context.ProductCategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (foundProductCat is null)
                return;
            foundProductCat.Code = entity.Code;
            foundProductCat.Description = entity.Description;
            foundProductCat.ProductType = entity.ProductType;
            context.SaveChanges();
        }
    }
}
