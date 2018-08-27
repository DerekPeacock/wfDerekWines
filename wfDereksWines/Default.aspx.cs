using System;
using System.Web.UI;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using wfDereksWines.Models;
using System.Linq;

namespace wfDereksWines
{
    public partial class _Default : Page
    {
        private WineDbContext db = new WineDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<Wine> GetWines()
        {
            IQueryable<Wine> wines = db.Wines;
            return wines;
        }
    }
}