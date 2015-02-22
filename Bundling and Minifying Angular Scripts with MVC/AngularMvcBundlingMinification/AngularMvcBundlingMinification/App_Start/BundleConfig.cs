using System.Web.Optimization;

namespace AngularMvcBundlingMinification
{
    public static class BundleConfig
    {
        public static void RegisterScriptBundles(BundleCollection bundles)
        {
            const string ANGULAR_APP_ROOT = "~/Client/scripts/app/";
            const string VIRTUAL_BUNDLE_PATH = ANGULAR_APP_ROOT + "main.js";

            var scriptBundle = new ScriptBundle(VIRTUAL_BUNDLE_PATH)
                .Include(ANGULAR_APP_ROOT + "app.js")
                .IncludeDirectory(ANGULAR_APP_ROOT, "*.js", searchSubdirectories: true);

            bundles.Add(scriptBundle);
        }
    }
}
