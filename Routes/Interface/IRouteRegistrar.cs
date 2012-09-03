using System;
using System.Linq;
using System.Web.Routing;

namespace Restfinity.Routes.Interface
{
    internal interface IRouteRegistrar
    {
        void RegisterRoute(RouteCollection routes);
    }
}
