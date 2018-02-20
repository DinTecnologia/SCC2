using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class EntidadeRepositorio : Repositorio<Entidade>, IEntidadeRepositorio
    {
        public EntidadeRepositorio(IDapperContexto context)
            : base(context)
        {
        }
    }
}
