using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class ConfiguracaoMapper : ClassMapper<Configuracao>
    {
        public ConfiguracaoMapper()
        {
            Table("Configuracoes");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Sigla).Column("Sigla");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.Valor).Column("Valor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
