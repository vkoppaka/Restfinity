using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class ForumThreadsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public ForumThreadsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "ForumThreadsGetAll",
                 routeTemplate: "restfinity/content/forumthreads/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod});

            routes.MapHttpRoute(
               name: "ForumThreadsGetOne",
               routeTemplate: "restfinity/content/forumthread/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "ForumThreadsGetAllOf",
               routeTemplate: "restfinity/content/forum/{id}/threads",
               defaults: new { controller = controllerName, action = "GetDetailsOf" });
        }

    }
}
