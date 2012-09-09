using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class ForumsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public ForumsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "ForumsGetAll",
                 routeTemplate: "restfinity/content/forums/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod});

            routes.MapHttpRoute(
               name: "ForumsGetOne",
               routeTemplate: "restfinity/content/forum/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "ForumsGetAllOf",
               routeTemplate: "restfinity/content/forumgroup/{id}/forums",
               defaults: new { controller = controllerName, action = "GetDetailsOf" });
        }

    }
}
