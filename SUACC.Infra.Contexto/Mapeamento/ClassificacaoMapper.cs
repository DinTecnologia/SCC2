using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class ClassificacaoMapper : ClassMapper<Classificacao>
    {
        public ClassificacaoMapper()
        {
            Table("Classificacoes");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.EntidadeIds).Column("EntidadeIds");
            Map(p => p.AtividadeTipoIds).Column("AtividadeTipoIds");
            Map(p => p.EntidadeIdsPadrao).Column("EntidadeIdsPadrao");
            Map(p => p.AtividadeTipoIdsPadrao).Column("AtividadeTipoIdsPadrao");
            Map(p => p.Direcao).Column("Direcao");
            Map(p => p.Finalizadora).Column("Finalizadora");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
