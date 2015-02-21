using System.Web.Optimization;

namespace AngularMvcDemo
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/Libraries/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/App/Controllers/CompanionshipController.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
