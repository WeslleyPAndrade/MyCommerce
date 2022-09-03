using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeslleyAndrade.AppMvc.Startup))]
namespace WeslleyAndrade.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
