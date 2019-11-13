using Unity;
using Unity.Resolution;
using BLL.Services.Interfaces;
using BLL.Services.ImplementedServices;

namespace BLL
{
    public static class DependencyInjectorBLL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();

        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();
            container.RegisterBLLTypes();

            return container;
        }

        public static void RegisterBLLTypes(this IUnityContainer container)
        {
            container
                .RegisterType<IAuthenticationService, AuthenticationService>()
                .RegisterType<IUserService, UserService>();
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}
