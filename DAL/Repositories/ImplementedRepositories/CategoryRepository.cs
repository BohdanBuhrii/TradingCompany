using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repositories.ImplementedRepositories
{
    public class CategoryRepository : BasicRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TradingCompanyContext context)
            : base(context)
        {

        }

        protected override IQueryable<Category> ConnectedEntities
        {
            get
            {
                return base.ConnectedEntities
                    .Include(c => c.CategoryGroup);
            }
        }
    }
}
