using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelProject1.Startup))]
namespace TravelProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
