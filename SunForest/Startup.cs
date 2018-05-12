using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunForest.Startup))]
namespace SunForest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
