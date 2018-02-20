using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class CampoDinamicoOpcaoRepositorio : Repositorio<CampoDinamicoOpcao>, ICampoDinamicoOpcaoRepositorio
    {
        public CampoDinamicoOpcaoRepositorio(IDapperContexto context)
              : base(context)
        {
        }
    }
}
