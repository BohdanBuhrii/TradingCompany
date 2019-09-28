using System;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TradingCompanyContext _context;

        private ICategoryGroupRepository _categoryGroupRepository;

        private ICategoryRepository _categoryRepository;

        private ICustomerRepository _customerRepository;

        private IDiscountRepository _discountRepository;

        private IManufacturerRepository _manufacturerRepository;

        private IProductRepository _productRepository;

        private IRoleRepository _roleRepository;

        private IUserRepository _userRepository;
        
        public UnitOfWork(TradingCompanyContext context)
        {
            _context = context;
        }

        public ICategoryGroupRepository CategoryGroupRepository
        {
            get
            {
                if (_categoryGroupRepository == null)
                {
                    _categoryGroupRepository = DependencyInjectorDAL.Resolve<ICategoryGroupRepository>();            
                }

                return _categoryGroupRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = DependencyInjectorDAL.Resolve<ICategoryRepository>();
                }

                return _categoryRepository;
            }
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = DependencyInjectorDAL.Resolve<ICustomerRepository>();
                }

                return _customerRepository;
            }
        }

        public IDiscountRepository DiscountRepository
        {
            get
            {
                if (_discountRepository == null)
                {
                    _discountRepository = DependencyInjectorDAL.Resolve<IDiscountRepository>();
                }

                return _discountRepository;
            }
        }

        public IManufacturerRepository ManufacturerRepository
        {
            get
            {
                if (_manufacturerRepository == null)
                {
                    _manufacturerRepository = DependencyInjectorDAL.Resolve<IManufacturerRepository>();
                }

                return _manufacturerRepository;
            }
            private set
            {
                _manufacturerRepository = value;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = DependencyInjectorDAL.Resolve<IProductRepository>();
                }

                return _productRepository;
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = DependencyInjectorDAL.Resolve<IRoleRepository>();
                }

                return _roleRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = DependencyInjectorDAL.Resolve<IUserRepository>();
                }

                return _userRepository;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
