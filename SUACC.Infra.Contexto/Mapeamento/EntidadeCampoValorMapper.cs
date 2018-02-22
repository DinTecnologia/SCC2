using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class EntidadeCampoValorMapper : ClassMapper<EntidadeCampoValor>
    {
        public EntidadeCampoValorMapper()
        {
            Table("EntidadeCampoValores");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.EntidadeId).Column("EntidadeId");
            Map(p => p.NomeCampo).Column("NomeCampo");
            Map(p => p.Valor).Column("Valor");
            Map(p => p.Padrao).Column("Padrao");
            Map(p => p.Ordem).Column("Ordem");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
