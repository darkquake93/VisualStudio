using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanSearch.Startup))]
namespace DanSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
