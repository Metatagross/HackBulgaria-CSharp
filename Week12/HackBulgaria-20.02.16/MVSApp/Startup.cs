using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVSApp.Startup))]
namespace MVSApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
