using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookTrade.Startup))]
namespace BookTrade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
