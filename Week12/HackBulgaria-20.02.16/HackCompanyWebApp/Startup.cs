using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackCompanyWebApp.Startup))]
namespace HackCompanyWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
