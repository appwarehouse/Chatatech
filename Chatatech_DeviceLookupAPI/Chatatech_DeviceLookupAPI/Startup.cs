using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chatatech_DeviceLookupAPI.Startup))]
namespace Chatatech_DeviceLookupAPI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
