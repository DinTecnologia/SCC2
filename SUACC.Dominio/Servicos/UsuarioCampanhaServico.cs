using System.Collections.Generic;
using DapperExtensions;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class UsuarioCampanhaServico : Servico<UsuarioCampanha>, IUsuarioCampanhaServico
    {
        private readonly IUsuarioCampanhaRepositorio _repositorio;

        public UsuarioCampanhaServico(IUsuarioCampanhaRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<UsuarioCampanha> ObterPor(string usuarioId, string campanhaId)
        {
            return _repositorio.ObterPor(usuarioId, campanhaId);
        }
    }
}
