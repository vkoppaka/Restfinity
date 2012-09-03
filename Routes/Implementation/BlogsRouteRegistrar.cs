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
        public override string ControllerName
        {
            get
            {
                return "Blogs";
            }
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "BlogsGetAll",
                 routeTemplate: "restfinity/content/blogs/",
                 defaults: new { controller = ControllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "BlogsGetOne",
               routeTemplate: "restfinity/content/blog/{id}",
               defaults: new { controller = ControllerName, action = DefaultGetMethod });
        }

    }
}
