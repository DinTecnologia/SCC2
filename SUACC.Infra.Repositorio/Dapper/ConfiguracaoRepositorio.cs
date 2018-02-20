using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;


namespace SUACC.Infra.Repositorio.Dapper
{
    public class ConfiguracaoRepositorio : Repositorio<Configuracao>,IConfiguracaoRepositorio
    {
        public ConfiguracaoRepositorio(IDapperContexto context)
            : base(context)
        {
        }
    }
}
