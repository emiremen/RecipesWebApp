﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.BusinessLayer.Interfaces
{
    public interface IService<TEntity>
    {
        public TEntity GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(int id);

    }
}
