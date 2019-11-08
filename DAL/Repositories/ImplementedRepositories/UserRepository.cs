using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repositories.ImplementedRepositories
{
    public class UserRepository : BasicRepository<User>, IUserRepository
    {
        public UserRepository(TradingCompanyContext context)
            :base(context)
        {

        }

        protected override IQueryable<User> ConnectedEntities
        { 
            get 
            { 
                return base.ConnectedEntities.Include(u => u.Role);
            }
        }
    }
}
