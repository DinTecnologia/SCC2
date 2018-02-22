using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class RemessaMapper : ClassMapper<Remessa>
    {
        public RemessaMapper()
        {
            Table("Remessas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.MailingId).Column("MailingId");
            Map(p => p.StatusEntidadeCampoValoresId).Column("StatusEntidadeCampoValoresId");
            Map(p => p.Ordem).Column("Ordem");
            Map(p => p.NomeArquivo).Column("NomeArquivo");
            Map(p => p.IniciadoEm).Column("IniciadoEm");
            Map(p => p.FinalizadoEm).Column("FinalizadoEm");
            Map(p => p.TotalLinhas).Column("TotalLinhas");
            Map(p => p.Erro).Column("Erro");
        }

    }
}
