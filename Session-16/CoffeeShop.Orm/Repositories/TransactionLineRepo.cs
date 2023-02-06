using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories {
    internal class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public void Create(TransactionLine entity) {
            using var context = new ApplicationDBContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new ApplicationDBContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.ID == id);
            if (foundTransactionLine is null)
                return;

            context.TransactionLines.Remove(foundTransactionLine);
            context.SaveChanges();
        }

        public List<TransactionLine> GetAll() {
            using var context = new ApplicationDBContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(Guid id) {
            using var context = new ApplicationDBContext();
            return context.TransactionLines.Where(TransactionLine => TransactionLine.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, TransactionLine entity) {
            using var context = new ApplicationDBContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.ID == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.Quantity = entity.Quantity;
            foundTransactionLine.TotalPrice = entity.TotalPrice;
            foundTransactionLine.Product = entity.Product;
            foundTransactionLine.ProductID = entity.ProductID;
            context.SaveChanges();
        }
    }
}
