using DAL.Repositories.ImplementedRepositories;
using DAL.Repositories.Interfaces;
using Unity;

namespace DAL
{
    public static class DependencyInjectorDAL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();

        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterTypes();

            return container;
        }

        private static void RegisterTypes(this IUnityContainer container)
        {
            container
                .RegisterType<ICategoryGroupRepository, CategoryGroupRepository>()
                .RegisterType<ICategoryRepository, CategoryRepository>()
                .RegisterType<ICustomerRepository, CustomerRepository>()
                .RegisterType<IDiscountRepository, DiscountRepository>()
                .RegisterType<IManufacturerRepository, ManufacturerRepository>()
                .RegisterType<IProductRepository, ProductRepository>()
                .RegisterType<IRoleRepository, RoleRepository>()
                .RegisterType<IUserRepository, UserRepository>();
        }

        public static T Resolve<T>()
        {
            return _unityContainer.Resolve<T>();
        }
    }
}
