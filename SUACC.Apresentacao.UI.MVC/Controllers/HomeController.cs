using System.Web.Mvc;

namespace SUACC.Apresentacao.UI.MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            return PartialView("_MenuEsquerdo");
        }

        public ActionResult DadosUsuario()
        {
            return PartialView("_DadosUsuario");
        }
    }
}