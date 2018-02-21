using System.Collections.Generic;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio.Comum;

namespace SUACC.Dominio.Interfaces.Repositorio
{
    public interface IUsuarioCampanhaRepositorio : IServico<UsuarioCampanha>
    {
        IEnumerable<UsuarioCampanha> ObterPor(string usuarioId, string campanhaId);
    }
}
