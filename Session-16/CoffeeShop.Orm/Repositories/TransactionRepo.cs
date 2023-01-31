using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Create(Transaction entity) {
            using var context = new ApplicationDBContext();
            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new ApplicationDBContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;

            context.Transactions.Remove(foundTrans);
            context.SaveChanges();
        }

        public List<Transaction> GetAll() {
            using var context = new ApplicationDBContext();
            return context.Transactions.ToList();
        }
        public Transaction? GetById(Guid id) {
            using var context = new ApplicationDBContext();
            return context.Transactions.Where(trans => trans.ID == id).SingleOrDefault(); ;
        }

        public void Update(Guid id, Transaction entity) {
            using var context = new ApplicationDBContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;
            foundTrans.Date = entity.Date;
            foundTrans.EmployeeID = entity.EmployeeID;
            foundTrans.CustomerID = entity.CustomerID;
            foundTrans.TransactionLines = entity.TransactionLines;
            foundTrans.PaymentMethod = entity.PaymentMethod;
            foundTrans.TotalPrice = entity.TotalPrice;
            foundTrans.TotalCost = entity.TotalCost;
            context.SaveChanges();
        }
    }
}
