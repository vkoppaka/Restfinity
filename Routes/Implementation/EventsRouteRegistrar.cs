using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;
using Restfinity.Routes.Interface;

namespace Restfinity.Routes.Implementation
{
    internal class EventsRouteRegistrar : BaseRouteRegistrar
    {
        public override string ControllerName
        {
            get
            {
                return "events";
            }
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "EventsGetAll",
                routeTemplate: "restfinity/content/events/",
                defaults: new { controller = ControllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
               name: "EventsGetOne",
               routeTemplate: "restfinity/content/event/{id}",
               defaults: new { controller = ControllerName, action = DefaultGetMethod });
        }
    }
}
