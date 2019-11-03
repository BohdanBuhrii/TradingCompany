using System;
using System.Threading.Tasks;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Unity.Resolution;

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

        public UnitOfWork()
        {
            _context = new TradingCompanyContext();
        }

        public ICategoryGroupRepository CategoryGroupRepository
        {
            get
            {
                if (_categoryGroupRepository == null)
                {
                    _categoryGroupRepository = DependencyInjectorDAL.
                        Resolve<ICategoryGroupRepository>(new ParameterOverride("context", _context));            
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
                    _categoryRepository = DependencyInjectorDAL.
                        Resolve<ICategoryRepository>(new ParameterOverride("context", _context));
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
                    _customerRepository = DependencyInjectorDAL
                        .Resolve<ICustomerRepository>(new ParameterOverride("context", _context));
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
                    _discountRepository = DependencyInjectorDAL
                        .Resolve<IDiscountRepository>(new ParameterOverride("context", _context));
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
                    _manufacturerRepository = DependencyInjectorDAL
                        .Resolve<IManufacturerRepository>(new ParameterOverride("context", _context));
                }

                return _manufacturerRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = DependencyInjectorDAL
                        .Resolve<IProductRepository>(new ParameterOverride("context", _context));
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
                    _roleRepository = DependencyInjectorDAL
                        .Resolve<IRoleRepository>(new ParameterOverride("context", _context));
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
                    _userRepository = DependencyInjectorDAL
                        .Resolve<IUserRepository>(new ParameterOverride("context", _context));
                }

                return _userRepository;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
