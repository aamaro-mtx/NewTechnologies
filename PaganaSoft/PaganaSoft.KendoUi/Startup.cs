using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaganaSoft.KendoUi.Startup))]
namespace PaganaSoft.KendoUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
