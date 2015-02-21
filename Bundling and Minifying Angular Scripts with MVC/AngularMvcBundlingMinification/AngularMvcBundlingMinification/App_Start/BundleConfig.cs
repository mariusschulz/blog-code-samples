using System.Web.Optimization;

namespace AngularMvcBundlingMinification
{
    public class BundleConfig
    {
        public static void RegisterScriptBundles(BundleCollection bundles)
        {
            const string ANGULAR_APP_ROOT = "~/Client/scripts/app/";

            var scriptBundle = new ScriptBundle(ANGULAR_APP_ROOT + "main.js")
                .Include(ANGULAR_APP_ROOT + "app.js")
                .IncludeDirectory(ANGULAR_APP_ROOT, "*.js", searchSubdirectories: true);

            bundles.Add(scriptBundle);
        }
    }
}
