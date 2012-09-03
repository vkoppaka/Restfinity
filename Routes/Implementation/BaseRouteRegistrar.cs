using Restfinity.Routes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal abstract class BaseRouteRegistrar : IRouteRegistrar
    {
        public const string DefaultGetMethod = "Get";
        public abstract void RegisterRoute(RouteCollection routes); 
    }
}
