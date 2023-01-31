using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Repositories {
    public interface IEntityRepo<TEntity>
        where TEntity : BaseEntity {
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Create(TEntity entity);
        void Update(Guid id, TEntity entity);
        void Delete(Guid id);
    }
}

