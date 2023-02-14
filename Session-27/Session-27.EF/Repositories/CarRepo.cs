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
    public class CarRepo : IEntityRepo<Car> {
        public void Add(Car entity) {
            using var context = new CarServiceCenterDbContext();
                context.Add(entity);
                context.SaveChanges();
        }
        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars
                .Where(car => car.Id == id)
                .Include(car => car.Transactions)
                .SingleOrDefault();
            if (CarDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(CarDb);
            context.SaveChanges();
        }

        public IList<Car> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Cars
                .Include(car => car.Transactions)
                .ToList();
        }
        public Car? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Cars
                .Where(car => car.Id == id)
                .Include(car => car.Transactions)
                .SingleOrDefault(); 
        }
        public void Update(int id, Car entity) {
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (CarDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            CarDb.Brand = entity.Brand;
            CarDb.Model = entity.Model;
            CarDb.CarRegistrationNumber = entity.CarRegistrationNumber;
            context.SaveChanges();
        }
 
    }
}