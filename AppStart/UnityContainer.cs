using KP_API.Core.ServiceInterface;
using KP_API.Service;
using Microsoft.Practices.Unity;

namespace KP_API.AppStart
{
    public class IocContainer
    {
        private static IUnityContainer _container = new UnityContainer();
        
        static IocContainer()
        {
            RegisterInterfaces();
        }

        private static void RegisterInterfaces()
        {
            _container.RegisterType<IMissionService,MissionService>();
        }

        public static T GetInstance<T>()
        {
            return _container.Resolve<T>();
        }
    }
}