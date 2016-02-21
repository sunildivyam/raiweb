using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(raiweb.Startup))]
namespace raiweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
