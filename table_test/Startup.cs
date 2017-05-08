using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(table_test.Startup))]
namespace table_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
