using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class TokenRepositorio : Repositorio<Token>, ITokenRepositorio
    {
        public TokenRepositorio(IDapperContexto context)
            : base(context)
        {
        }
    }
}
