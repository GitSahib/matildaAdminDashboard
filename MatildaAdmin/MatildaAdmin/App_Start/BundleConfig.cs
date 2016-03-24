using System.Web;
using System.Web.Optimization;

namespace MVC5App
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/js/jquery-migrate-1.0.0.min.js",

                        "~/Scripts/js/jquery-ui-1.10.0.custom.min.js",

                        "~/Scripts/js/jquery.ui.touch-punch.js",

                        "~/Scripts/js/modernizr.js",

                        "~/Scripts/js/jquery.cookie.js",

                        "~/Scripts/js/fullcalendar.min.js",

                        "~/Scripts/js/jquery.dataTables.min.js",

                        "~/Scripts/js/excanvas.js",
                        "~/Scripts/js/jquery.flot.js",
                        "~/Scripts/js/jquery.flot.pie.js",
                        "~/Scripts/js/jquery.flot.stack.js",
                        "~/Scripts/js/jquery.flot.resize.min.js",

                        "~/Scripts/js/jquery.chosen.min.js",

                        "~/Scripts/js/jquery.uniform.min.js",

                        "~/Scripts/js/jquery.cleditor.min.js",

                        "~/Scripts/js/jquery.noty.js",

                        "~/Scripts/js/jquery.elfinder.min.js",

                        "~/Scripts/js/jquery.raty.min.js",

                        "~/Scripts/js/jquery.iphone.toggle.js",

                        "~/Scripts/js/jquery.uploadify-3.1.min.js",

                        "~/Scripts/js/jquery.gritter.min.js",

                        "~/Scripts/js/jquery.imagesloaded.js",

                        "~/Scripts/js/jquery.masonry.min.js",

                        "~/Scripts/js/jquery.knob.modified.js",

                        "~/Scripts/js/jquery.sparkline.min.js",
                        
                        "~/Scripts/js/counter.js",
                        
                        "~/Scripts/js/retina.js",
                        
                        "~/Scripts/js/custom.js",
                        
                        "~/Scripts/js/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/css/bootstrap-responsive.min.css", 
                      "~/Content/css/style.css", 
                      "~/Content/css/style-responsive.css"));
        }
    }
}
