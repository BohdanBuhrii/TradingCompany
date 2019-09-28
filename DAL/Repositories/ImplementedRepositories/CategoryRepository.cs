using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class CategoryRepository : BasicRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TradingCompanyContext context)
            : base(context)
        {

        }
    }
}
