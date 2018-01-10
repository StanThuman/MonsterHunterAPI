using System.Web.Http;
using Unity;
using Unity.WebApi;
using MonsterHunterAPI.IoC;
using System.Web.Mvc;

namespace MonsterHunterAPI.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            UnityResolver.RegisterServices(container);

            DependencyResolver.SetResolver(new Unity.AspNet.Mvc.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}