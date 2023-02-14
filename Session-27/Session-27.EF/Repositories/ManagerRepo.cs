using Session_27.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Session_27.Model;
using Session_27.Model.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.EF.Repositories {
    public class ManagerRepo : IEntityRepo<Manager> {
        public void Add(Manager entity) {
            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
                return;
            context.Remove(dbManager);
            context.SaveChanges();
        }

        public IList<Manager> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Managers
                .Include(manager => manager.Transactions)
                .Include(Manager => Manager.Engineers)
                .ToList();
        }

        public Manager? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Managers.Where(manager => manager.Id == id)
                .Include(manager => manager.Transactions)
                .Include(Manager => Manager.Engineers)
                .SingleOrDefault();
        }

        public void Update(int id, Manager entity) {
            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null)
                return;
            dbManager.Name = entity.Name;
            dbManager.Surname = entity.Surname;
            dbManager.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }
    }
}
