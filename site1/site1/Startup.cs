using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(site1.Startup))]
namespace site1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
