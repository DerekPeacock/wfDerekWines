using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using wfDereksWines.Models;
using System.Data.Entity;

namespace wfDereksWines
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new WineDbInitialiser());
        }
    }
}