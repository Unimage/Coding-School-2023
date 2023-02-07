using CoffeeShop.Model;
using CoffeeShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        public void Create(Employee entity) {
            using var context = new ApplicationDBContext();
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new ApplicationDBContext();
            var foundEmployee = context.Employees.SingleOrDefault(prodCat => prodCat.ID == id);
            if (foundEmployee is null)
                return;
            context.Employees.Remove(foundEmployee);
            context.SaveChanges();
        }

        public List<Employee> GetAll() {
            using var context = new ApplicationDBContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id) {
            using var context = new ApplicationDBContext();
            return context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
        }

        public void Update(Guid id, Employee entity) {
            using var context = new ApplicationDBContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;
            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.Salary = entity.Salary;
            foundEmployee.EmployeeType = entity.EmployeeType;
            context.SaveChanges();
        }
    }
}
