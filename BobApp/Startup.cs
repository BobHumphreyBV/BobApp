using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BobApp.Startup))]
namespace BobApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
