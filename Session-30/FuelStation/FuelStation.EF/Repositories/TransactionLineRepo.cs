using FuelStation.EF.Context;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {

        public void Add(TransactionLine entity) {
            using var context = new ApplicationContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
            throw new NotImplementedException();
        }

        public IList<TransactionLine> GetAll() {
            throw new NotImplementedException();
        }

        public TransactionLine? GetById(Guid ID) {
            throw new NotImplementedException();
        }

        public void Update(Guid ID, TransactionLine entity) {
            throw new NotImplementedException();
        }
    }
}
