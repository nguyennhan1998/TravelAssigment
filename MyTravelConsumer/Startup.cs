using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTravelConsumer.Startup))]
namespace MyTravelConsumer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
