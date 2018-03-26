using System.Collections.Generic;

namespace SUACC.Aplicacao.ViewModel
{
    public class MenuViewModel
    {
        public MenuViewModel(string titulo, IEnumerable<MenuItemViewModel> itens)
        {
            Titulo = titulo;
            Itens = itens;
        }

        public string Titulo { get; set; }
        public IEnumerable<MenuItemViewModel> Itens { get; set; }
    }

    public class MenuItemViewModel
    {
        public MenuItemViewModel(int menuId, string nome, string tipoAbertura, string icone, int menuPaiId, string controllerNome, string actionNome, string parametros)
        {
            MenuId = menuId;
            Nome = nome;
            TipoAbertura = tipoAbertura;
            Icone = icone;
            MenuPaiId = menuPaiId;
            ControllerName = controllerNome;
            ActionName = actionNome;
            Parametros = parametros;
        }

        public int MenuId { get; set; }
        public string Nome { get; set; }
        public string TipoAbertura { get; set; }
        public string Icone { get; set; }
        public int MenuPaiId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Parametros { get; set; }
    }
}
