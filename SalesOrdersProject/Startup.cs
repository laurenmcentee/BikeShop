using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesOrdersProject.Startup))]
namespace SalesOrdersProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
