using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;
using Restfinity.Routes.Interface;

namespace Restfinity.Routes.Implementation
{
    internal class EcommerceProductsRouteRegistrar : BaseRouteRegistrar
    {
        public override string ControllerName
        {
            get
            {
                return "ecommerceproducts";
            }
        }

        public override void RegisterRoute(RouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "ProductsGetAll",
                routeTemplate: "restfinity/ecommerce/products",
                defaults: new { controller = ControllerName, action = DefaultGetMethod });

            routes.MapHttpRoute(
                name: "ProductsGetOne",
                routeTemplate: "restfinity/ecommerce/product/{id}",
                defaults: new { controller = ControllerName, action = DefaultGetMethod });
        }
    }
}
