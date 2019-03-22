using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using SportsStore.Models.Repository;
using SportsStore.Models;

namespace SportsStore.Pages.Admin
{
    public partial class Products : System.Web.UI.Page
    {
        private Repository repo = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Product> GetProducts()
        {
            return repo.Products;
        }

        public void UpdateProduct(int productID)
        {

        }
    }
}