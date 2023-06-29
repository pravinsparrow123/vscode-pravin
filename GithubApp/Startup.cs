using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubApp.Startup))]
namespace GithubApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
