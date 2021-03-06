﻿using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

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
