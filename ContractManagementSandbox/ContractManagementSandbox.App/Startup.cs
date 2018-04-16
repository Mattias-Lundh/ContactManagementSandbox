using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractManagementSandbox.App.Startup))]
namespace ContractManagementSandbox.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
