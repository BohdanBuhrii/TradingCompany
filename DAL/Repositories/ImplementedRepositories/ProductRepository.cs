using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class ProductRepository : BasicRepository<Product>, IProductRepository
    {
        public ProductRepository(TradingCompanyContext context)
            :base(context)
        {

        }
    }
}
