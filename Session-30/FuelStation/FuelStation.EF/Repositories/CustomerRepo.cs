using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new ApplicationContext();
            return context.Customers
                .Include(customer => customer.Transactions)
                .ToList();
        }
        public Customer? GetById(Guid ID) {
            using var context = new ApplicationContext();
            return context.Customers
                .Where(customer => customer.ID == ID)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
        }
        public void Update(Guid ID, Customer entity) {
            using var context = new ApplicationContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.ID == ID)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            CustomerDb.Name = entity.Name;
            CustomerDb.Surname = entity.Surname;
            CustomerDb.CardNumber = entity.CardNumber;
            context.SaveChanges();
        }
        public void Delete(Guid ID) {
            using var context = new ApplicationContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.ID == ID)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null)
                throw new KeyNotFoundException($"Given id '{ID}' was not found");
            context.Remove(CustomerDb);
            context.SaveChanges();
        }
    }
}
