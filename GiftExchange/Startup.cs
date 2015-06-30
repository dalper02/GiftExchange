using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiftExchange.Startup))]
namespace GiftExchange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
