using System.Collections.Generic;
using DapperExtensions;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class UsuarioCampanhaRepositorio : Repositorio<UsuarioCampanha>, IUsuarioCampanhaRepositorio
    {
        public UsuarioCampanhaRepositorio(IDapperContexto context)
            : base(context)
        {
        }

        public IEnumerable<UsuarioCampanha> ObterPor(string usuarioId, string campanhaId)
        {
            var where = new PredicateGroup { Operator = GroupOperator.And, Predicates = new List<IPredicate>() };

            if (!string.IsNullOrEmpty(usuarioId))
                where.Predicates.Add(Predicates.Field<UsuarioCampanha>(f => f.UsuarioId, Operator.Eq, usuarioId));

            if (!string.IsNullOrEmpty(campanhaId))
                where.Predicates.Add(Predicates.Field<UsuarioCampanha>(f => f.CampanhaId, Operator.Eq, campanhaId));

            return ObterPor(where);
        }
    }
}
