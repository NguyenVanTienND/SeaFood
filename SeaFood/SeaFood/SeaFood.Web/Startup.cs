using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeaFood.Web.Startup))]
namespace SeaFood.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
