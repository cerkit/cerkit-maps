using System.Web;
using System.Web.Optimization;

namespace cerkitMaps
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.globalize/globalize.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/devextreme").Include(
                      "~/Scripts/dx.all.debug.js",
                      "~/Scripts/dx.webappjs.debug.js",
                      "~/Scripts/dx.chartjs.debug.js",
                      "~/Scripts/devextreme-modules/dx.module-core.debug.js",
                      "~/Scripts/devextreme-modules/dx.module-viz-core.debug.js",
                      "~/Scripts/devextreme-modules/dx.module-viz-charts.debug.js",
                      "~/Scripts/devextreme-modules/dx.module-viz-vectormap.debug",
                      "~/Scripts/devextreme-modules/vectormap-utils/dx.vectormaputils.debug.js"                      
                      ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
