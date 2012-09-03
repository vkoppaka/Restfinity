using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;
using Restfinity.Routes.Interface;

namespace Restfinity.Routes.Implementation
{
    internal class NewsRouteRegistrar : BaseRouteRegistrar
    {
        public override string ControllerName
        {
            get
            {
                return "news";
            }
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "NewsGetAll",
                routeTemplate: "restfinity/content/news/",
                defaults: new { controller = "news", action = "get" });

            routes.MapHttpRoute(
               name: "NewsGetOne",
               routeTemplate: "restfinity/content/news/{id}",
               defaults: new { controller = "news", action = "get" });
        }
    }
}
