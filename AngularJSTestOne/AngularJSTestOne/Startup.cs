using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSTestOne.Startup))]
namespace AngularJSTestOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
