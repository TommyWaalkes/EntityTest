using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBFirstTest.Startup))]
namespace DBFirstTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
