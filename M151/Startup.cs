using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M151.Startup))]
namespace M151
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
