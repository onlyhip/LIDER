using System.Web;
using System.Web.Optimization;

namespace LIDER
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Assets/js/jquery-1.10.2.js",
                        "~/Content/Assets/ItemSlider/js/modernizr.custom.63321.js",
                        "~/Content/Assets/ItemSlider/js/jquery.catslider.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/Assets/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/Assets/css").Include(
                    "~/Content/Assets/css/bootstrap.css",
                    "~/Content/Assets/css/font-awesome.min.css",
                    "~/Content/Assets/ItemSlider/css/main-style.css",
                    "~/Content/Assets/css/style.css"));

        }
    }
}
