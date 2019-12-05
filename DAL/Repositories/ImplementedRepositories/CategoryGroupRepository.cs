using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repositories.ImplementedRepositories
{
    public class CategoryGroupRepository : BasicRepository<CategoryGroup>, ICategoryGroupRepository
    {
        public CategoryGroupRepository(TradingCompanyContext context)
            : base(context)
        {

        }

        protected override IQueryable<CategoryGroup> ConnectedEntities
        {
            get
            {
                return base.ConnectedEntities
                    .Include(cg => cg.Categories);
            }
        }
    }
}
