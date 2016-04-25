using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSMVC.Domain.Startup))]
namespace AngularJSMVC.Domain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
