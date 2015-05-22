using System.Web.Optimization;

namespace ImeiValidator.WebApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/sammy-{version}.js",
                "~/Scripts/Chart.js",
                "~/Scripts/knockout.chart.extension.js",
                "~/Scripts/app/common.js",
                "~/Scripts/app/imei.viewmodel.js",
                "~/Scripts/app/piechart.viewmodel.js",
                "~/Scripts/app/app.viewmodel.js",
                "~/Scripts/app/_run.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/feedback_me").Include(
                "~/Scripts/jquery.feedback_me.js"));

            bundles.Add(new StyleBundle("~/Content/cssStyles").Include(
                "~/Content/bootstrap.css",
                "~/Content/jquery.feedback_me.css",
                 "~/Content/Site.css"));

            BundleTable.Bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                "~/Content/css/font-awesome.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = WebApplicationConfiguration.EnableOptimizations;
        }
    }
}
