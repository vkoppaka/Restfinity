using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;
using Restfinity.Routes.Interface;

namespace Restfinity.Routes.Implementation
{
    internal class EventsRouteRegistrar : BaseRouteRegistrar
    {
        private readonly string controllerName;

        public EventsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "EventsGetAll",
                routeTemplate: "restfinity/content/events/",
                defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "EventsGetOne",
               routeTemplate: "restfinity/content/event/{id}",
               defaults: new { controller = controllerName, action = DefaultGetMethod });
        }
    }
}
