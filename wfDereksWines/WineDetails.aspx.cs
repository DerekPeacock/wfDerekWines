using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using wfDereksWines.Models;

namespace wfDereksWines
{
    public partial class WineDetails : System.Web.UI.Page
    {
        private WineDbContext db = new WineDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Wine> GetWine([QueryString("WineID")] int? wineId)
        {
            IQueryable<Wine> wines = db.Wines;

            if (wineId.HasValue && wineId > 0)
            {
                wines = wines.Where(w => w.WineID == wineId);
            }
            else wines = null;

            return wines;

        }
    }
}