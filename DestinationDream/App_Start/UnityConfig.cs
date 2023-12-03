using DestinationDream.IServices;
using DestinationDream.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DestinationDream
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ICities,CitiesRepo>();
            container.RegisterType<ICountry, CountryRepo>();
            container.RegisterType<IState, StateRepo>();
            container.RegisterType<ICompanyType, CompanyTypeRepo>();
            container.RegisterType<ITicketType, TicketTypeRepo>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}