using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrintFarm.Startup))]
namespace PrintFarm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
