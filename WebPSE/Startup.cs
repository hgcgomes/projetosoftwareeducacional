using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPSE.Startup))]
namespace WebPSE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
