using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AtendimentoInteracaoMapper : ClassMapper<AtendimentoInteracao>
    {
        public AtendimentoInteracaoMapper()
        {
            Table("AtendimentoInteracoes");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.AtendimentoId).Column("AtendimentoId");
            Map(p => p.AtividadeId).Column("AtividadeId");
            Map(p => p.OcorrenciaId).Column("OcorrenciaId");
            Map(p => p.CriadoEm).Column("CriadoEm");
        }
    }
}
