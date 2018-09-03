using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wfDereksWines.BusinessLogic;

namespace wfDereksWines
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["WineID"];
            int wineId;

            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out wineId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a WineId.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a WineId.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}