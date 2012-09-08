using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.Http;

namespace Restfinity.Routes.Implementation
{
    internal class ForumGroupsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public ForumGroupsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "ForumGroupsGetAll",
                 routeTemplate: "restfinity/content/forumgroups/",
                 defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "ForumGroupsGetOne",
               routeTemplate: "restfinity/content/forumgroup/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });
        }

    }
}
