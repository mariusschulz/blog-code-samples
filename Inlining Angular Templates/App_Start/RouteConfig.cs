using System.Web.Mvc;
using System.Web.Routing;

namespace InliningAngularTemplates
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("AngularTemplates", "templates/{name}", new { controller = "AngularTemplates", action = "Template" });

            routes.MapRoute("Default", "{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}
