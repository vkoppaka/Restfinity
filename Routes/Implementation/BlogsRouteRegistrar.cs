using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.Http;

namespace Restfinity.Routes.Implementation
{
    internal class BlogsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public BlogsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "BlogsGetAll",
                 routeTemplate: "restfinity/content/blogs/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "BlogsGetOne",
               routeTemplate: "restfinity/content/blog/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });
        }

    }
}
