using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineShop.WebInterface.Startup))]
namespace OnlineShop.WebInterface
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
