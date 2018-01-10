using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Net.Http.Headers;
using MonsterHunterAPI.IoC;
using Unity;
using MonsterHunterAPI.Domain.Repositories;
using MonsterHunterAPI.Domain.Services;
using Unity.Lifetime;
using System.Net.Http.Formatting;

namespace MonsterHunterAPI.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //var container = new UnityContainer();
            ////UnityResolver.RegisterServices()
            //container.RegisterType<IWeaponsRepository, IWeaponsRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IWeaponsService, IWeaponsService>(new HierarchicalLifetimeManager());
            //config.DependencyResolver = new UnityResolver(container);
            
            //allow cross origin

            //config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            ////change deault data to JSON
            //config.Formatters.JsonFormatter.SupportedMediaTypes
            //    .Add(new MediaTypeHeaderValue("text/html"));

            config.Formatters.Add(new JSONHeader());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "mhunter/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }


    public class JSONHeader : JsonMediaTypeFormatter
    {
        public JSONHeader()
        {
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            this.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        }

        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {

            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
}
