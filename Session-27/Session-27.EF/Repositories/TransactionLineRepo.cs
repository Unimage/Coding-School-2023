using Session_27.EF.Repositories;
using Session_27.Model.EF.Context;
using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Session_27.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public void Add(TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();
                context.Add(entity);
                context.SaveChanges();
        }
        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Engineer)
                .Include(transactionLine => transactionLine.ServiceTask)
                .SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(TransactionLineDb);
            context.SaveChanges();
        }
        public IList<TransactionLine> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Engineer)
                .Include(transactionLine => transactionLine.ServiceTask)
                .ToList();
        }
        public IList<TransactionLine> GetAllWithTransactionID(int transactionId) {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(t => t.TransactionId == transactionId)
                .Include(t => t.Engineer)
                .Include(t => t.ServiceTask)
                .ToList();
        }
        public TransactionLine? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines
                .Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Engineer)
                .Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Transaction)
                .SingleOrDefault();
        }
        public void Update(int id, TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.Id == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Engineer)
                .Include(transactionLine => transactionLine.ServiceTask)
                .SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            TransactionLineDb.Price = entity.Price;
            TransactionLineDb.PricePerHour = entity.PricePerHour;
            TransactionLineDb.Hours = entity.Hours;
            TransactionLineDb.ServiceTaskId = entity.ServiceTaskId;
            TransactionLineDb.EngineerId = entity.EngineerId;

            context.SaveChanges();
        }
    }
}

