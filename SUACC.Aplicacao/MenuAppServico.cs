using SUACC.Dominio.Interfaces.Servicos;

namespace SUACC.Aplicacao
{
    public class MenuAppServico
    {
        IMenuServico _menuServico;

        public MenuAppServico(IMenuServico menuServico)
        {
            _menuServico = menuServico;
        }
    }
}
