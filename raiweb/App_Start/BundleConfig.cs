using System.Web;
using System.Web.Optimization;

namespace raiweb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var headerExternalLibsBundle = new ScriptBundle("~/scripts/headerExternalLibs");
            var footerExternalLibsBundle = new ScriptBundle("~/scripts/footerExternalLibs");
            var footerClientLibsBundle = new ScriptBundle("~/clientlibs/footerClientLibs");
            var styleBundle = new StyleBundle("~/styles");

            headerExternalLibsBundle
               .Include("~/Scripts/respond.js",
                   "~/Scripts/modernizr-{version}.js");

            footerExternalLibsBundle
                .Include("~/Scripts/jquery-{version}.js",
                    "~/Scripts/angular.js",
                    "~/Scripts/angular-ui-router.js",
                    "~/Scripts/bootstrap.js");

            footerClientLibsBundle.IncludeDirectory("~/Scripts/clientlibs/common", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/home", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/clients", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/contact", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/about", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/portfolio", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/services", "*.js", true)
                .IncludeDirectory("~/Scripts/clientlibs/team", "*.js", true);

            bundles.Add(headerExternalLibsBundle);
            bundles.Add(footerExternalLibsBundle);
            bundles.Add(footerClientLibsBundle);

            //LESS/ CSS Bundling
            styleBundle.Include("~/Content/bootstrap.css")               
                .IncludeDirectory("~/Content/less", "*.less", false);

            styleBundle.Transforms.Add(new LessTransform());

            bundles.Add(styleBundle);

            BundleTable.EnableOptimizations = false;
        }
    }
}
