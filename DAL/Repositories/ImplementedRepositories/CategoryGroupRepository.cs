using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class CategoryGroupRepository : BasicRepository<CategoryGroup>, ICategoryGroupRepository
    {
        public CategoryGroupRepository(TradingCompanyContext context)
            : base(context)
        {

        }
    }
}
