using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
           
        }

        public IList<Transaction> GetAll() {
            using var context = new ApplicationContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(Guid ID) {
            using var context = new ApplicationContext();
            return context.Transactions
                .Where(transaction => transaction.ID == ID)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transLine => transLine.Item)
                .SingleOrDefault();
        }

        public void Update(Guid ID, Transaction entity) {
            throw new NotImplementedException();
        }
    }
}
