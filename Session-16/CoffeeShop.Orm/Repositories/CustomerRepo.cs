using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using CoffeeShop.Orm.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Create(Customer entity) {
            using var context = new ApplicationDBContext();
            context.Customers.Add(entity);
             context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new ApplicationDBContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            context.SaveChanges();
        }

        public List<Customer> GetAll() {
            using var context = new ApplicationDBContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new ApplicationDBContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Customer entity) {
            using var context = new ApplicationDBContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Code = entity.Code;
            foundCustomer.Description = entity.Description;
            foundCustomer.TransactionList = entity.TransactionList;

            context.SaveChanges();
        }
    }
}
