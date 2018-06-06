using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookTradeA.Startup))]
namespace BookTradeA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
