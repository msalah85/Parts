using ShareWeb.CarsParts.Repository;
using Unity;
using Unity.Mvc5;
using System.Web.Mvc;

namespace ShareWeb.CarsParts
{
    public static class UnityConfig
    {
        // Add this method in Application_Start in MVC
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType(typeof(IRepository<>), typeof(GenericRepository<>));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
