using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio.Comum;
using System.Collections.Generic;

namespace SUACC.Dominio.Interfaces.Repositorio
{
    public interface IMenuRepositorio : IServico<Menu>
    {
        IEnumerable<Menu> ObterPor(string usuarioId, string url, string aplicacaoId = null);
    }
}
