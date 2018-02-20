using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class OcorrenciaRepositorio : Repositorio<Ocorrencia>, IOcorrenciaRepositorio
    {
        public OcorrenciaRepositorio(IDapperContexto context)
             : base(context)
        {
        }
    }
}
