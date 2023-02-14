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
    public class ServiceTaskRepo : IEntityRepo<ServiceTask> {
        public void Add(ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
                context.Add(entity);
                context.SaveChanges();
        }
        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks
                .Where(serviceTask => serviceTask.Id == id)
                .Include(serviceTask => serviceTask.TransactionLines)
                .SingleOrDefault();
            if (ServiceTaskDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(ServiceTaskDb);
            context.SaveChanges();
        }

        public IList<ServiceTask> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.ToList();

        }
        public ServiceTask? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();

        }
        public void Update(int id, ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (ServiceTaskDb is null)
                return;
            ServiceTaskDb.Code = entity.Code;
            ServiceTaskDb.Description = entity.Description;
            ServiceTaskDb.Hours = entity.Hours;
            context.SaveChanges();
        }
    }
}

