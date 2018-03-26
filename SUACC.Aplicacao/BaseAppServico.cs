using AutoMapper;
using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos;
using System.Collections.Generic;
using System.Linq;

namespace SUACC.Aplicacao
{
    public class BaseAppServico : IBaseAppServico
    {
        private readonly IMenuServico _menuServico;

        public BaseAppServico(IMenuServico menuServico)
        {
            _menuServico = menuServico;
        }

        public MenuViewModel ObterMenu(string usuarioId, string url, string namespaceArea)
        {
            var menus = _menuServico.ObterPor(usuarioId, url, null);

            var itens = new List<MenuItemViewModel>();

            if (menus.Any())
            {
                foreach (var menu in menus)
                {
                    itens.Add(Mapper.Map<Menu, MenuItemViewModel>(menu));
                }

                return new MenuViewModel("SUACC", itens);
            }
            else
                return new MenuViewModel("SUACC", itens);
        }
    }
}
