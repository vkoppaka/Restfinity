using System;
using System.Linq;
using System.Web.Routing;
using Restfinity.Routes.Interface;

namespace Restfinity.Routes.Implementation
{
    internal abstract class BaseRouteRegistrar : IRouteRegistrar
    {
        public const string DefaultGetMethod = "Get";
        public abstract void RegisterRoute(RouteCollection routes); 
    }
}
