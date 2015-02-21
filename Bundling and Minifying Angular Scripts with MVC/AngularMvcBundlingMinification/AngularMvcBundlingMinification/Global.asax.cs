using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AngularMvcBundlingMinification
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            BundleConfig.RegisterScriptBundles(BundleTable.Bundles);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
