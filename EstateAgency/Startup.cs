using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstateAgency.Startup))]
namespace EstateAgency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
