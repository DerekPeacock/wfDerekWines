﻿using System;
using System.Web.UI;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using wfDereksWines.Models;
using System.Linq;
using System.Web.ModelBinding;

namespace wfDereksWines
{
    public partial class _Default : Page
    {
        private WineDbContext db = new WineDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<Wine> GetAllWines()
        {
            IQueryable<Wine> wines = db.Wines;
            return wines;
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