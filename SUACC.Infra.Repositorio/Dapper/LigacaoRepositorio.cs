using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class LigacaoRepositorio : Repositorio<Ligacao>, ILigacaoRepositorio
    {
        public LigacaoRepositorio(IDapperContexto context)
             : base(context)
        {
        }
    }
}
