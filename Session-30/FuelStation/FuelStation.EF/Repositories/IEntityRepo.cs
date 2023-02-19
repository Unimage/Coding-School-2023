using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public interface IEntityRepo<TEntity> {
        IList<TEntity> GetAll();
        TEntity? GetById(Guid ID);
        void Add(TEntity entity);
        void Update(Guid ID, TEntity entity);
        void Delete(Guid ID);
    }
}
