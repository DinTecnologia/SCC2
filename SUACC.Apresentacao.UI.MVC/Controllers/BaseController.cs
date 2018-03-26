using Microsoft.AspNet.Identity;
using SUACC.Aplicacao.Interfaces;
using System.Web;
using System.Web.Mvc;

namespace SUACC.Apresentacao.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IConfiguracaoAppServico configuracaoAppServico)
        {

        }

        public string UsuarioId
        {
            get
            {
                return ControllerContext.HttpContext.User.Identity.GetUserId();
            }
        }

        public string CarregarMenu()
        {

            var routeData = HttpContext.Request.RequestContext.RouteData;
            return routeData.ToString();

            //currentNamespace = controllerFullName.Substring(0, controllerFullName.IndexOf("." + currentController, System.StringComparison.Ordinal));
            //return System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace;
        }
    }
}