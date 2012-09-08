using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.Http;

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
