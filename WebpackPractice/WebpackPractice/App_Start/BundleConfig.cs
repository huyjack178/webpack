﻿using System.Web;
using System.Web.Optimization;

namespace WebpackPractice
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/indexStyle").Include(
                      "~/Content/Index.css"));

            bundles.Add(new StyleBundle("~/Content/aboutStyle").Include(
                      "~/Content/About.css"));

            bundles.Add(new ScriptBundle("~/scripts/common").Include(
                       "~/Scripts/jquery-1.10.2.js",
                       "~/Scripts/bootstrap.js"));

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
