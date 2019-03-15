using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportsStore.Models.Repository;
using SportsStore.Helpers;
using SportsStore.Pages.Helpers;
using System.Web.Routing;

namespace SportsStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repo = new Repository();
        private int pageSize = 4;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int selectedProductId;

                if (int.TryParse(Request.Form["add"], out selectedProductId))
                {
                    Product selectedProduct = repo.Products
                        .Where(p => p.ProductID == selectedProductId).FirstOrDefault();
                    if (selectedProduct != null)
                    {
                        SessionHelpers.GetCart(Session).AddItem(selectedProduct, 1);
                        SessionHelpers.Set(Session, SessionKey.RETURN_URL,
                            Request.RawUrl);

                        Response.Redirect(RouteTable.Routes
                            .GetVirtualPath(null, "cart", null).VirtualPath);
                    }
                }
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return FilterProducts()
                .OrderBy(p => p.ProductID)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }

        private IEnumerable<Product> FilterProducts()
        {
            IEnumerable<Product> products = repo.Products;
            string currentCategory = (string)RouteData.Values["category"] ??
                Request.QueryString["category"];
            return currentCategory == null ? products
                : products.Where(p => p.Category == currentCategory);
        }

        protected int CurrentPage
        {
            get
            {
                int page = GetPageFromRequest();
                //page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                return page > MaxPage ? MaxPage : page;
            }
        }

        protected int MaxPage
        {
            get
            {
                int productCount = FilterProducts().Count();
                return (int)Math.Ceiling((decimal)productCount / pageSize);
            }
        }

        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ?? 
                Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? 
                page : 1;

        }
    }
}