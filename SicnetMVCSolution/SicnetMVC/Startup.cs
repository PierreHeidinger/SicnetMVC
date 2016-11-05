using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SicnetMVC.Startup))]
namespace SicnetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
