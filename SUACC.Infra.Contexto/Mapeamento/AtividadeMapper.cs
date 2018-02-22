using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AtividadeMapper : ClassMapper<Atividade>
    {
        public AtividadeMapper()
        {
            Table("Atividades");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtividadeTipoId).Column("AtividadeTipoId");
            Map(p => p.CanalId).Column("CanalId");
            Map(p => p.ClassificacaoId).Column("ClassificacaoId");
            Map(p => p.ClienteId).Column("ClienteId");
            Map(p => p.OcorrenciaId).Column("OcorrenciaId");
            Map(p => p.AtendimentoId).Column("AtendimentoId");
            Map(p => p.AtividadeDeOrigemId).Column("AtividadeDeOrigemId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.PrevisaoAtendimento).Column("PrevisaoAtendimento");
            Map(p => p.PrevisaoFinalizar).Column("PrevisaoFinalizar");
            Map(p => p.IniciadoEm).Column("IniciadoEm");
            Map(p => p.IniciadoPor).Column("IniciadoPor");
            Map(p => p.FinalizadoEm).Column("FinalizadoEm");
            Map(p => p.FinalizadoPor).Column("FinalizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
