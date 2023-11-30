using Microsoft.EntityFrameworkCore;
using Recipes.CoreLayer.Entities;
using Recipes.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private AppDbContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return  _dbSet.FirstOrDefault(x=>x.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _dbSet.AsEnumerable();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            TEntity entity = _dbSet.FirstOrDefault(x => x.Id == id);
           if (entity != null)
            {
                _dbSet.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
