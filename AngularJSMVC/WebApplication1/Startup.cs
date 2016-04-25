using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSMVC.WebSite.Startup))]
namespace AngularJSMVC.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
