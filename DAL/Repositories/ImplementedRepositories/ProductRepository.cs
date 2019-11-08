using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repositories.ImplementedRepositories
{
    public class ProductRepository : BasicRepository<Product>, IProductRepository
    {
        public ProductRepository(TradingCompanyContext context)
            :base(context)
        {

        }

        protected override IQueryable<Product> ConnectedEntities
        {
            get
            {
                return base.ConnectedEntities
                    .Include(p => p.Customer)
                    .Include(p => p.Category)
                    .Include(p => p.Manufacturer);
            }
        }
    }
}
