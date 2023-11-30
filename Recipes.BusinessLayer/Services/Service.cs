using Recipes.BusinessLayer.Interfaces;
using Recipes.CoreLayer.Entities;
using Recipes.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.BusinessLayer.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity
    {
        IGenericRepository<TEntity> _repository;

        public Service(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
           return _repository.GetById(id);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
