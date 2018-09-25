using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FSDWebApp.Startup))]
namespace FSDWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
