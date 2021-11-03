using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS350_BaggingApplication.Startup))]
namespace CS350_BaggingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
