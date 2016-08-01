using System.Web;
using System.Web.Optimization;

namespace WebpackPractice
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/indexStyle").Include(
                      "~/Content/Index.css"));

            bundles.Add(new StyleBundle("~/Content/aboutStyle").Include(
                      "~/Content/About.css"));

            bundles.Add(new ScriptBundle("~/scripts/common").Include(
                       "~/Scripts/jquery-1.10.2.js"));

            bundles.Add(new ScriptBundle("~/scripts/index").Include(
                "~/Scripts/app/message.js",
                //"~/Scripts/app/message-extension.js",
                "~/Scripts/app/index.js"));

            bundles.Add(new ScriptBundle("~/scripts/about").Include(
                "~/Scripts/app/message.js",
                "~/Scripts/app/about.js"));
        }
    }
}
