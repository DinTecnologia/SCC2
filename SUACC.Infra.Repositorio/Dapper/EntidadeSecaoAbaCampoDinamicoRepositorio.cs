using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;


namespace SUACC.Infra.Repositorio.Dapper
{   
    public class EntidadeSecaoAbaCampoDinamicoRepositorio : Repositorio<EntidadeSecaoAbaCampoDinamico>, IEntidadeSecaoAbaCampoDinamicoRepositorio
    {
        public EntidadeSecaoAbaCampoDinamicoRepositorio(IDapperContexto context)
            : base(context)
        {
        }
    }
}
