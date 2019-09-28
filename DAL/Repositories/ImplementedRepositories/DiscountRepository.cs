using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class DiscountRepository : BasicRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(TradingCompanyContext context)
            :base(context)
        {

        }
    }
}
