using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using System;
using System.Net;
using System.Web.Mvc;

namespace SUACC.Apresentacao.UI.MVC.Controllers
{
    [Authorize]
    public class ClienteController : BaseController
    {
        private readonly IClienteAppServico _clienteAppServico;        

        public ClienteController(IConfiguracaoAppServico configuracaoAppServico, IClienteAppServico clienteAppServico) : base(configuracaoAppServico)
        {
            _clienteAppServico = clienteAppServico;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar(bool viewModal = true)
        {
            var viewModel = _clienteAppServico.Novo(UsuarioId);
            return PartialView("_Adicionar", viewModel);
        }

        [HttpPost]
        public ActionResult Adicionar(ClienteCadastroViewModel viewModel, bool partialView = true)
        {
            return View();
        }

        [Route("editar/{id:guid}")]
        public ActionResult Editar(Guid? id, bool partialView = true)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var viewModel = _clienteAppServico.ObterPorId(id.Value);

            if (viewModel == null)
                return HttpNotFound();

            return View(viewModel);
        }


        [Route("editar/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ClienteCadastroViewModel viewModel, bool partialView = true)
        {
            if (ModelState.IsValid)
            {
                _clienteAppServico.Atualizar(viewModel);
                return RedirectToAction("Index");
            }

            if (partialView)
                return PartialView("_Editar", viewModel);
            else
                return View(viewModel);
        }

        //[ClaimsAuthorize("PermissoesCliente", "CX")]
        [Route("excluir/{id:guid}")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var viewModel = _clienteAppServico.ObterPorId(id.Value);

            if (viewModel == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        //[ClaimsAuthorize("PermissoesCliente", "CX")]
        [Route("excluir/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clienteAppServico.Remover(id);
            return RedirectToAction("Index");
        }

        public ActionResult ListarEnderecos(Guid id)
        {
            ViewBag.ClienteId = id;
            return PartialView("_EnderecosList", _clienteAppServico.ObterPorId(id).Enderecos);
        }

        [Route("adicionar-endereco")]
        public ActionResult AdicionarEndereco(Guid id)
        {
            ViewBag.ClienteId = id;
            return PartialView("_AdicionarEndereco");
        }

        [Route("adicionar-endereco")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdicionarEndereco(ClienteEnderecoCadastroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteAppServico.AdicionarEndereco(viewModel);

                string url = Url.Action("ListarEnderecos", "Clientes", new { id = viewModel.ClienteId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AdicionarEndereco", viewModel);
        }

        [Route("adicionar-endereco/{id:guid}")]
        public ActionResult AtualizarEndereco(Guid id)
        {
            return PartialView("_AtualizarEndereco", _clienteAppServico.ObterEnderecoPorId(id));
        }

        [Route("adicionar-endereco/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarEndereco(ClienteEnderecoCadastroViewModel enderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteAppServico.AtualizarEndereco(enderecoViewModel);

                string url = Url.Action("ListarEnderecos", "Clientes", new { id = enderecoViewModel.ClienteId });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarEndereco", enderecoViewModel);
        }

        [Route("excluir-endereco/{id:guid}")]
        public ActionResult DeletarEndereco(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var enderecoViewModel = _clienteAppServico.ObterEnderecoPorId(id.Value);
            if (enderecoViewModel == null)
            {
                return HttpNotFound();
            }
            return PartialView("_DeletarEndereco", enderecoViewModel);
        }        

        [Route("excluir-endereco/{id:guid}")]
        [HttpPost, ActionName("DeletarEndereco")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarEnderecoConfirmed(Guid id)
        {
            var clienteId = _clienteAppServico.ObterEnderecoPorId(id).ClienteId;
            _clienteAppServico.RemoverEndereco(id);

            string url = Url.Action("ListarEnderecos", "Clientes", new { id = clienteId });
            return Json(new { success = true, url = url });
        }

    }
}