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
        }

        public void Delete(Guid ID) {
           
        }

        public IList<Transaction> GetAll() {
            using var context = new ApplicationContext();
            return context.Transactions
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .ToList();
        }

        public Transaction? GetById(Guid ID) {
            throw new NotImplementedException();
        }

        public void Update(Guid ID, Transaction entity) {
            throw new NotImplementedException();
        }
    }
}
