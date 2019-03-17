using SportsStore.Models;
using SportsStore.Models.Repository;
using SportsStore.Pages.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Repository repo = new Repository();
                int prodId;

                if (int.TryParse(Request.Form["remove"], out prodId)) ;
                {
                    Product prodToRemove = repo.Products.Where(
                        p => p.ProductID == prodId).FirstOrDefault();
                    if (prodToRemove != null)
                    {
                        // remove from cart
                        SessionHelpers.GetCart(Session).RemoveLine(prodToRemove);
                    }
                }
            }
        }

        public IEnumerable<CartLine> GetCartLines()
        {
            return SessionHelpers.GetCart(Session).Lines;
        }

        public decimal CartTotal
        {
            get
            {
                return SessionHelpers.GetCart(Session).ComputeTotalValue();
            }
        }

        public string ReturnUrl
        {
            get
            {
                return SessionHelpers.Get<string>(Session, SessionKey.RETURN_URL);
            }
        }
    }
}