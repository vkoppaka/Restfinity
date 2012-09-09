using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class NewsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public NewsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "NewsGetAll",
                routeTemplate: "restfinity/content/news/",
                defaults: new { controller = controllerName, action = "get" });

            routes.MapHttpRoute(
               name: "NewsGetOne",
               routeTemplate: "restfinity/content/news/{id}",
               defaults: new { controller = controllerName, action = "get" });
        }
    }
}
