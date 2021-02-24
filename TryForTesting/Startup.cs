using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryForTesting.Startup))]
namespace TryForTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
