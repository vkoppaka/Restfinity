using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using Restfinity.Routes.Implementation;
using Restfinity.Routes.Interface;

namespace Restfinity.Routes
{
    public class RouteRegistrar
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Ignore("{resource}.axd/{*pathInfo}");

            foreach (IRouteRegistrar routeRegistrar in GetRouteRegistrars())
            {
                routeRegistrar.RegisterRoute(routes);
            }
        }

        private static IEnumerable<IRouteRegistrar> GetRouteRegistrars()
        {
            return new IRouteRegistrar[]
            {
                new EcommerceProductsRouteRegistrar(Constants.EcommerceProductsControllerName),
                new NewsRouteRegistrar(Constants.NewsControllerName),
                new EventsRouteRegistrar(Constants.EventsControllerName),
                new BlogsRouteRegistrar(Constants.BlogsControllerName),
                new BlogPostsRouteRegistrar(Constants.BlogPostsControllerName),
                new ListsRouteRegistrar(Constants.ListsControllerName),
                new ListItemsRouteRegistrar(Constants.ListItemsControllerName),
                new ForumGroupsRouteRegistrar(Constants.ForumGroupsControllerName),
                new ForumsRouteRegistrar(Constants.ForumsControllerName),
                new ForumThreadsRouteRegistrar(Constants.ForumThreadsControllerName),
                new ForumPostsRouteRegistrar(Constants.ForumPostsControllerName)
            };
        }
    }
}
