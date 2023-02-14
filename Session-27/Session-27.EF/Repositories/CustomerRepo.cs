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
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            using var context = new CarServiceCenterDbContext();
                context.Add(entity);
                context.SaveChanges();
        }
        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(CustomerDb);
            context.SaveChanges();
        }
        public IList<Customer> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Customers
                .Include(customer => customer.Transactions)
                .ToList();
        }
        public Customer? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Customers
                .Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
        }
        public void Update(int id, Customer entity) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.Id == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null) throw new KeyNotFoundException($"Given id '{id}' was not found");
            CustomerDb.Name = entity.Name;
            CustomerDb.Surname = entity.Surname;
            CustomerDb.Phone = entity.Phone;
            CustomerDb.Tin = entity.Tin;
            context.SaveChanges();
        }
    }
}