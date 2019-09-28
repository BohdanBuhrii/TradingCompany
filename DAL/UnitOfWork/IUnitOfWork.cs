using DAL.Repositories.Interfaces;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICategoryGroupRepository CategoryGroupRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public ICustomerRepository CustomerRepository { get; }
        public IDiscountRepository DiscountRepository { get; }
        public IManufacturerRepository ManufacturerRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IRoleRepository RoleRepository { get; }
        public IUserRepository UserRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
