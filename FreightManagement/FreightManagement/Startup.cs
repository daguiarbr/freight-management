using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreightManagement.Startup))]
namespace FreightManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
