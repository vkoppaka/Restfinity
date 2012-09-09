using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class BlogPostsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public BlogPostsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "BlogPostsGetAll",
                 routeTemplate: "restfinity/content/blogposts/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod});

            routes.MapHttpRoute(
               name: "BlogPostsGetOne",
               routeTemplate: "restfinity/content/blogpost/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "BlogPostsGetAllOf",
               routeTemplate: "restfinity/content/blog/{id}/posts",
               defaults: new { controller = controllerName, action = "GetDetailsOf" });
        }

    }
}
