using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeslleyAndrade.AppMVC.Startup))]
namespace WeslleyAndrade.AppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
