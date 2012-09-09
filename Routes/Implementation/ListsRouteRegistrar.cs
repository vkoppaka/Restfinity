using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class ListsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public ListsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "ListsGetAll",
                 routeTemplate: "restfinity/content/lists/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "ListsGetOne",
               routeTemplate: "restfinity/content/list/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });
        }

    }
}
