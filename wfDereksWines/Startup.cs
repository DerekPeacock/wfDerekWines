using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wfDereksWines.Startup))]
namespace wfDereksWines
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
