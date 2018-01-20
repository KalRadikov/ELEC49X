using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OCEAN_Analysis49X.Startup))]
namespace OCEAN_Analysis49X
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
