using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForXHLH.Startup))]
namespace WebForXHLH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
