using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeaFood.Startup))]
namespace SeaFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
