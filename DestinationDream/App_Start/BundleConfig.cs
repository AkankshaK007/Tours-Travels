using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace DestinationDream.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/AllJQ").Include(
                            "~/JS/bootstrap.bundle.js",
                         "~/JS/code.jquery.com_jquery-3.7.1.js",
                         "~/JS/jquery.dataTables.min.js",
                         "~/JS/jquery.validate.min.js",
                         "~/JS/jquery.validate.unobtrusive.min.js",
                         "~/JS/jquery.min.js"));
                        

            bundles.Add(new StyleBundle("~/AllCSS").Include(
             "~/CSS/bootstrap.min.css",
             "~/CSS/jquery.dataTables.min.css"));


            // This line of code enable bundling
            BundleTable.EnableOptimizations = true;
        }
    }
}