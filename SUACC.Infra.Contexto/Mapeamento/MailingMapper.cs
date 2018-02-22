using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class MailingMapper : ClassMapper<Mailing>
    {
        public MailingMapper()
        {
            Table("Mailing");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.NomeArquivo).Column("NomeArquivo");
            Map(p => p.NomePlanilha).Column("NomePlanilha");
            Map(p => p.DiretorioLeituraConfiguracaoId).Column("DiretorioLeituraConfiguracaoId");
            Map(p => p.DiretorioProcessamentoConfiguracaoId).Column("DiretorioProcessamentoConfiguracaoId");
            Map(p => p.TipoArquivoEntidadeValorCampoId).Column("TipoArquivoEntidadeValorCampoId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
        }
    }
}
