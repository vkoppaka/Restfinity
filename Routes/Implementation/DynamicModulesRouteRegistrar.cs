using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class DynamicModulesRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public DynamicModulesRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "DynamicModulesGetAll",
                 routeTemplate: "restfinity/dynamicmodules/all/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod });
        }
    }
}
