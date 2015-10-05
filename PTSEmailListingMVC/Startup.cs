using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PTSEmailListingMVC.Startup))]
namespace PTSEmailListingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
