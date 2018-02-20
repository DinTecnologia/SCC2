using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class MenuServico : Servico<Menu>, IMenuServico
    {
        public MenuServico(IMenuRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
