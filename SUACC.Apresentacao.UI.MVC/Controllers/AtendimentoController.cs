using System.Web.Mvc;
using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;

namespace SUACC.Apresentacao.UI.MVC.Controllers
{
    public class AtendimentoController : BaseController
    {
        private readonly IAtendimentoAppServico _atendimentoAppServico;

        public AtendimentoController(IConfiguracaoAppServico configuracaoAppServico, IAtendimentoAppServico appServico)
            : base(configuracaoAppServico)
        {
            _atendimentoAppServico = appServico;
        }

        // GET: Atendimento
        public ActionResult Index()
        {
            var teste = CarregarMenu();
            return View();
        }

        public ActionResult AtendimentoReceptivo(AtendimentoCadastroViewModel model)
        {
            model.UsuarioId = UsuarioId;
            var viewModel = _atendimentoAppServico.NovaLigacaoReceptiva(model);
            return View("Index", viewModel);
        }
    }
}