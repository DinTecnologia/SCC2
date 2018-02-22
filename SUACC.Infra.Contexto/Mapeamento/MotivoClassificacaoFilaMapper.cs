using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class MotivoClassificacaoFilaMapper : ClassMapper<MotivoClassificacaoFila>
    {
        public MotivoClassificacaoFilaMapper()
        {
            Table("MotivoClassificacaoFilas");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.MotivoClassificacaoId).Column("MotivoClassificacaoId");
            Map(p => p.FilaId).Column("FilaId");
            Map(p => p.AtividadeTipoId).Column("AtividadeTipoId");
            Map(p => p.EmailModeloId).Column("EmailModeloId");
            Map(p => p.SlaAtendimento).Column("SlaAtendimento");
            Map(p => p.SlaFechamento).Column("SlaFechamento");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
