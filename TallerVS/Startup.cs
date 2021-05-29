using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TallerVS.Startup))]
namespace TallerVS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
