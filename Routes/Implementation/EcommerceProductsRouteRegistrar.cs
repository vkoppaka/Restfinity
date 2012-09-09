using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Restfinity.Routes.Implementation
{
    internal class EcommerceProductsRouteRegistrar : BaseRouteRegistrar
    {
       private readonly string controllerName;

        public EcommerceProductsRouteRegistrar(string controllerName)
        {
            this.controllerName = controllerName;
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "ProductsGetAll",
                routeTemplate: "restfinity/ecommerce/products",
                defaults: new { controller = controllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
                name: "ProductsGetOne",
                routeTemplate: "restfinity/ecommerce/product/{id}",
                defaults: new { controller = controllerName, action = DefaultGetMethod });
        }
    }
}
