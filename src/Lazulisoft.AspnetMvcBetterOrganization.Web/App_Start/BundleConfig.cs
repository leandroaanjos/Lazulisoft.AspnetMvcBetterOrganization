using System.Web.Optimization;

namespace Lazulisoft.AspnetMvcBetterOrganization.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JS
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/wwwroot/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/wwwroot/lib/jquery/dist/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/wwwroot/lib/jquery.validate/dist/jquery.validate.js",
                        "~/wwwroot/lib/jquery.validate.unobtrusive/dist/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/wwwroot/lib/bootstrap/js/bootstrap.js"));

            // CSS
            bundles.Add(new StyleBundle("~/bundles/sitecss").Include("~/wwwroot/css/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
