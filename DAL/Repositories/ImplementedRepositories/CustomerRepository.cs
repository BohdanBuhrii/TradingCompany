using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class CustomerRepository : BasicRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(TradingCompanyContext context)
            : base(context)
        {

        }
    }
}
