﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace SportsStore
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/validation").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobstrusive.js"));
        }
    }
}