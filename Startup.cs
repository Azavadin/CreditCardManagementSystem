using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreditCardManagementSystem.Startup))]
namespace CreditCardManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
