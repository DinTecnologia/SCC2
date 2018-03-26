using Microsoft.AspNet.Identity;
using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SUACC.Apresentacao.UI.MVC.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
            //this.Notifications = DomainEvent.Container.GetInstance<IHandler<DomainNotification>>();
            //@ViewBag.PageTitle = configuracaoAppServico.ObterTitle();
            //@ViewBag.PageTitleMenu = configuracaoAppServico.ObterTitleMenu();
        }

        public string UsuarioId
        {
            get
            {
                return ControllerContext.HttpContext.User.Identity.GetUserId();
            }
        }

        public Dictionary<string, object> ObterErrosDaModelState()
        {
            var errors = new Dictionary<string, object>();
            foreach (var key in ModelState.Keys)
            {
                if (ModelState[key].Errors.Count > 0)
                {
                    errors[key] = ModelState[key].Errors;
                }
            }

            return errors;
        }

        public string VarrerTodosErros(ValidationResult validacaoResultado)
        {
            var mensagemErro = "";

            if (validacaoResultado.Errors != null)
            {
                foreach (var erro in validacaoResultado.Errors)
                {
                    if (String.IsNullOrEmpty(mensagemErro))
                    {
                        mensagemErro = erro.Message;
                    }
                    else
                        mensagemErro += "\r\n" + erro.Message;
                }
            }

            return mensagemErro;
        }

        public string CarregarMenu()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace;
        }
    }
}