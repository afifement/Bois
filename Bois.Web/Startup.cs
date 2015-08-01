using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bois.Web.Startup))]

namespace Bois.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}