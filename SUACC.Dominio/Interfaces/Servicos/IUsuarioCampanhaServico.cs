using System.Collections.Generic;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;

namespace SUACC.Dominio.Interfaces.Servicos
{
    public interface IUsuarioCampanhaServico : IServico<UsuarioCampanha>
    {
        IEnumerable<UsuarioCampanha> ObterPor(string usuarioId, string campanhaId);
    }
}
