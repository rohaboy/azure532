using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azure_532_lab.Startup))]
namespace azure_532_lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
