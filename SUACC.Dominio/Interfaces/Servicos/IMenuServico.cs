using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;
using System.Collections.Generic;

namespace SUACC.Dominio.Interfaces.Servicos
{
    public interface IMenuServico : IServico<Menu>
    {
        IEnumerable<Menu> ObterPor(string usuarioId, string url, string aplicacaoId = null);
    }
}
