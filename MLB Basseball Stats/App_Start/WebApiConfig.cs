using Microsoft.Practices.Unity;
using MLB_Baseball_Stats.Models;
using MLB_Basseball_Stats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MLB_Basseball_Stats
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var dbContext = new Context();
            IRepository repo = new Repository();

            ObjFactory.Instance.RegisterInstance<Context>(dbContext);
            ObjFactory.Instance.RegisterInstance<IRepository>(repo);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }

    public static class ObjFactory
    {
        private static UnityContainer objFactory = new UnityContainer();

        public static UnityContainer Instance
        {
            get { return objFactory; }
        }
    }
}