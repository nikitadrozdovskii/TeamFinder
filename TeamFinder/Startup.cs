using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamFinder.Startup))]
namespace TeamFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
