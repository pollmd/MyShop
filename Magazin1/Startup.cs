using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Magazin1.Startup))]
namespace Magazin1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
