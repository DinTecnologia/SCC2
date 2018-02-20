using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class MailingRepositorio : Repositorio<Mailing>, IMailingRepositorio
    {
        public MailingRepositorio(IDapperContexto context)
             : base(context)
        {
        }
    }
}
