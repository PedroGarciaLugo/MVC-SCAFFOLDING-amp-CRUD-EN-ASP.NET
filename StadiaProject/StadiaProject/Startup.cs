using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StadiaProject.Startup))]
namespace StadiaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
