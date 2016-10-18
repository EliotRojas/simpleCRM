using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(simpleCRM.Startup))]
namespace simpleCRM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
