using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SUACC.Apresentacao.UI.MVC.Startup))]
namespace SUACC.Apresentacao.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
