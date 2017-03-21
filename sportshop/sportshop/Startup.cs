using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sportshop.Startup))]
namespace sportshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
