using DAL.Repositories.ImplementedRepositories;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Unity;
using Unity.Resolution;

namespace DAL
{
    public static class DependencyInjectorDAL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();

        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();

            return container;
        }

        public static void RegisterDALTypes(this IUnityContainer container)
        {
            container
                .RegisterType<ICategoryGroupRepository, CategoryGroupRepository>()
                .RegisterType<ICategoryRepository, CategoryRepository>()
                .RegisterType<ICustomerRepository, CustomerRepository>()
                .RegisterType<IDiscountRepository, DiscountRepository>()
                .RegisterType<IManufacturerRepository, ManufacturerRepository>()
                .RegisterType<IProductRepository, ProductRepository>()
                .RegisterType<IRoleRepository, RoleRepository>()
                .RegisterType<IUserRepository, UserRepository>()
                .RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}
