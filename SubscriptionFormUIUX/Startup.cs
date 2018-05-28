using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SubscriptionFormUIUX.Startup))]
namespace SubscriptionFormUIUX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
