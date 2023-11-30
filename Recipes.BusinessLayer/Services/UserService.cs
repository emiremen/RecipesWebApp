using Recipes.CoreLayer.Entities;
using Recipes.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.BusinessLayer.Services
{
    public  class UserService : Service<User>
    {
        public UserService(IGenericRepository<User> genericRepository):base(genericRepository)
        {
            
        }
    }
}
