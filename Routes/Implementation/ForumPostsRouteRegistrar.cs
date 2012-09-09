using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class ForumPostsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public ForumPostsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "ForumPostsGetAll",
                 routeTemplate: "restfinity/content/forumposts/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod});

            routes.MapHttpRoute(
               name: "ForumPostsGetOne",
               routeTemplate: "restfinity/content/forumpost/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "ForumPostsGetAllOf",
               routeTemplate: "restfinity/content/forumthread/{id}/posts",
               defaults: new { controller = controllerName, action = "GetDetailsOf" });
        }

    }
}
