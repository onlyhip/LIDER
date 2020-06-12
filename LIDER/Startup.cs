using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LIDER.Startup))]
namespace LIDER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
