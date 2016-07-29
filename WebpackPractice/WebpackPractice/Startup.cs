using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebpackPractice.Startup))]
namespace WebpackPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
