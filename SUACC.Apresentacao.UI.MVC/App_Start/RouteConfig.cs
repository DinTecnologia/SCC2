using System.Web.Mvc;
using System.Web.Routing;

namespace SUACC.Apresentacao.UI.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "SUACC.Apresentacao.UI.MVC.Controllers" }
            );
        }
    }
}
