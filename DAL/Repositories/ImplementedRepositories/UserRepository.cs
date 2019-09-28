using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class UserRepository : BasicRepository<User>, IUserRepository
    {
        public UserRepository(TradingCompanyContext context)
            :base(context)
        {

        }
    }
}
