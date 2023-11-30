using Recipes.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.DataAccessLayer.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AppDbContext appDbContext):base(appDbContext)
        {
            
        }
    }
}
