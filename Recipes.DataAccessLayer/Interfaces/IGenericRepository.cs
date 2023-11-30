using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DataAccessLayer.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        TEntity GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(int id);
    }
}
