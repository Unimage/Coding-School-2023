using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class ItemRepo:IEntityRepo<Item> {
        public void Add(Item entity) {
            using var context = new ApplicationContext();
            context.Add(entity);
            context.SaveChanges();
        }
        public IList<Item> GetAll() {
            using var context = new ApplicationContext();
            return context.Items
                .Include(item => item.TransactionLines)
                .ToList();
        }
        public Item? GetById(Guid ID) {
            using var context = new ApplicationContext();
            return context.Items
                .Where(item => item.ID == ID)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
        }

        public void Update(Guid ID, Item entity) {
            using var context = new ApplicationContext();
            var ItemDb = context.Items
                .Where(item => item.ID == ID)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
            if (ItemDb is null) throw new KeyNotFoundException($"Given id '{ID}' was not found");
            ItemDb.Description = entity.Description;
            ItemDb.Code= entity.Code;
            ItemDb.Price= entity.Price;
            ItemDb.Cost= entity.Cost;
            ItemDb.ItemType= entity.ItemType;
            context.SaveChanges();
        }
        public void Delete(Guid ID) {
            using var context = new ApplicationContext();
            var ItemDb = context.Items
                .Where(item => item.ID == ID)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
            if (ItemDb is null)
                throw new KeyNotFoundException($"Given id '{ID}' was not found");
            context.Remove(ItemDb);
            context.SaveChanges();
        }
    }

}
