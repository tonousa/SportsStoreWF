using SportsStore.Helpers;
using SportsStore.Models;
using SportsStore.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Controls
{
    public partial class CartSummary : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart mycart = SessionHelpers.GetCart(Session);
            csQuantity.InnerText = mycart.Lines.Sum(l => l.Quantity).ToString();
            csTotal.InnerText = mycart.ComputeTotalValue().ToString("c");
            csLink.HRef = RouteTable.Routes
                .GetVirtualPath(null, "cart", null).VirtualPath;
        }
    }
}