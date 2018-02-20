using SUACC.Aplicacao.Interfaces;
using System.Web.Mvc;

namespace SUACC.Apresentacao.UI.MVC.Controllers
{
    public class AplicacaoController : BaseController
    {
        private readonly IAplicacaoAppServico _appServico;

        public AplicacaoController(IConfiguracaoAppServico configuracaoAppServico, IAplicacaoAppServico appServico) : base(configuracaoAppServico)
        {
            _appServico = appServico;
        }

        // GET: Aplicacao
        public ActionResult Index()
        {
            var retorno = _appServico.ObterTodos();
            return View();
        }

    }
}