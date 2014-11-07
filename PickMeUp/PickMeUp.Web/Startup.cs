using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PickMeUp.Web.Startup))]
namespace PickMeUp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
