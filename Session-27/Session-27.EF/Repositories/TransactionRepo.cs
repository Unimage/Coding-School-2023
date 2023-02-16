using Microsoft.EntityFrameworkCore;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Model.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new CarServiceCenterDbContext();
                context.Add(entity);
                context.SaveChanges();
        }
        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions
                .Where(transaction => transaction.Id == id)
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car)
                .Include(transaction => transaction.Manager)
                .SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(TransactionDb);
            context.SaveChanges();
        }
        public IList<Transaction> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions
                
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car)
                .Include(transaction => transaction.Manager)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Engineer)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.ServiceTask)
                .ToList();
        }
        public Transaction? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions
                .Where(transaction => transaction.Id == id)
                
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Car)
                .Include(transaction => transaction.Manager)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Engineer)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.ServiceTask)
                .SingleOrDefault();
        }
        public void Update(int id, Transaction entity) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions
                .Where(transaction => transaction.Id == id)
                .SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            TransactionDb.Date = entity.Date;
            TransactionDb.CustomerId = entity.CustomerId;
            TransactionDb.CarId = entity.CarId;
            TransactionDb.ManagerId = entity.ManagerId;
            TransactionDb.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }
    }
}