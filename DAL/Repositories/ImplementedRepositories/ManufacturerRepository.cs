using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class ManufacturerRepository : BasicRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(TradingCompanyContext context)
            :base(context)
        {

        }
    }
}
