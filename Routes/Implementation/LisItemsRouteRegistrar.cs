using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class ListItemsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public ListItemsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "ListItemsGetAll",
                 routeTemplate: "restfinity/content/listitems/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod});

            routes.MapHttpRoute(
               name: "ListItemsGetOne",
               routeTemplate: "restfinity/content/listitem/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "ListItemsGetAllOf",
               routeTemplate: "restfinity/content/list/{id}/items",
               defaults: new { controller = controllerName, action = "GetDetailsOf" });
        }

    }
}
