using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        public void Add(Employee entity) {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
            using var context = new ApplicationContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.ID == ID)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null)
                throw new KeyNotFoundException($"Given id '{ID}' was not found");
            context.Remove(EmployeeDb);
            context.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var context = new ApplicationContext();
            return context.Employees
                .Include(employee => employee.Transactions)
                .ToList();
        }

        public Employee? GetById(Guid ID) {
            using var context = new ApplicationContext();
            return context.Employees
                .Where(employee => employee.ID == ID)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
        }

        public void Update(Guid ID, Employee entity) {
            using var context = new ApplicationContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.ID == ID)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            EmployeeDb.Name = entity.Name;
            EmployeeDb.Surname= entity.Surname;
            EmployeeDb.SallaryPerMonth = entity.SallaryPerMonth;
            EmployeeDb.EmployeeType = entity.EmployeeType;
            EmployeeDb.HireDateStart= entity.HireDateStart;
            EmployeeDb.HireDateEnd = entity.HireDateEnd;
            EmployeeDb.username= entity.username;
            EmployeeDb.password= entity.password;
            context.SaveChanges();
        }
    }
}
