using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MshopWorkShop.Startup))]
namespace MshopWorkShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
