using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySchedule.WebUI.Startup))]
namespace MySchedule.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
