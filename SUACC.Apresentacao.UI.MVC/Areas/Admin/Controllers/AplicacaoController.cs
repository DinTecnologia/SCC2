using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using System;
using System.Web.Mvc;

namespace SUACC.Apresentacao.UI.MVC.Areas.Admin.Controllers
{
    public class AplicacaoController : AdminController
    {
        IAplicacaoAppServico _aplicacaoAppServico;

        public AplicacaoController(IAplicacaoAppServico aplicacaoAppServico)
        {
            _aplicacaoAppServico = aplicacaoAppServico;
        }

        // GET: Admin/Aplicacao
        public ActionResult Index()
        {
            var teste = CarregarMenu();
            return View();
        }

        public ActionResult Adicionar()
        {
            return PartialView("_Adicionar");
        }

        [HttpPost]
        public ActionResult Adicionar(AplicacaoAddViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Json(new { statusRequisicao = "erroModel", campos = ObterErrosDaModelState() });

                viewModel.CriadoPor = UsuarioId;
                var retorno = _aplicacaoAppServico.Adicionar(viewModel);

                if (retorno.IsValid)
                    return Json(new { statusRequisicao = "sucesso", mensagem = "Aplicação Adicionada com Sucesso" });

                return Json(new { statusRequisicao = "erro", mensagem = retorno.Errors });
            }
            catch (Exception ex)
            {
                return Json(new { statusRequisicao = "erro", mensagem = ex.Message });
            }
        }

        public ActionResult Listar()
        {
            return View();
        }
    }
}