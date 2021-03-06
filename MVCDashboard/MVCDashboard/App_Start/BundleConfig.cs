﻿using System.Web;
using System.Web.Optimization;

namespace MVCDashboard
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

            bundles.Add(new StyleBundle("~/Content/plugins").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //main

            bundles.Add(new StyleBundle("~/Content/Admin").Include(
                    "~/Content/bootstrap/css/bootstrap.css",
                    "~/Content/dist/css/AdminLTE.min.css",
                    "~/Content/dist/css/skins/_all-skins.min.css",
                    "~/Content/plugins/iCheck/flat/blue.css ",
                    "~/Content/plugins/morris/morris.css",
                    "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                    "~/Content/plugins/datepicker/datepicker3.css",
                    "~/Content/plugins/daterangepicker/daterangepicker-bs3.css",
                    "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
                ));
        }
    }
}
