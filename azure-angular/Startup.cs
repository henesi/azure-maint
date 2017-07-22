using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azure_angular.Startup))]
namespace azure_angular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
