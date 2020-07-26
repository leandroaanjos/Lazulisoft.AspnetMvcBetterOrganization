using System.Web;
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
            bundles.Add(new StyleBundle("~/bundles/sitecss")
                .Include("~/wwwroot/lib/bootstrap/css/bootstrap.css", new CssRewriteUrlTransformWrapper())
                .Include("~/wwwroot/css/site.css"));

            // To avoid change the file to .min version
            BundleTable.Bundles.FileExtensionReplacementList.Clear();

            // Enable the bundling and minification of bundle references
            BundleTable.EnableOptimizations = true;
        }
    }

    // https://stackoverflow.com/questions/19765238/cssrewriteurltransform-with-or-without-virtual-directory
    // Solution to: The problem appears when your application isn't hosted at the server root, but in a virtual directory
    // Ex: /path/to/my/appRoot/
    public class CssRewriteUrlTransformWrapper : IItemTransform
    {
        public string Process(string includedVirtualPath, string input)
        {
            return new CssRewriteUrlTransform().Process("~" + VirtualPathUtility.ToAbsolute(includedVirtualPath), input);
        }
    }
}