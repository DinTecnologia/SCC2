using Microsoft.AspNet.Identity;
using SUACC.Aplicacao.Interfaces;
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
    }
}