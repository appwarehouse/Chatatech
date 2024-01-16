using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chatatech_DeviceLookup.Startup))]
namespace Chatatech_DeviceLookup
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
