using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FruitCart.Startup))]
namespace FruitCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
