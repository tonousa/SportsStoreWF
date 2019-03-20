﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

//namespace SportsStore.App_Start
namespace SportsStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{category}/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");

            routes.MapPageRoute("cart", "cart", "~/pages/CartView.aspx");
            routes.MapPageRoute("checkout", "checkout", "~/pages/Checkout.aspx");

            routes.MapPageRoute("admin_orders", "admin/orders",
                "~/Pages/Admin/Orders.aspx");
            routes.MapPageRoute("admin_products", "admin/products",
                "~/Pages/Admin/Products.aspx");
        }
    }
}