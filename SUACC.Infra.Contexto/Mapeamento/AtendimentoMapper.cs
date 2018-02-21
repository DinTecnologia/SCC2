using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AtendimentoMapper : ClassMapper<Atendimento>
    {
        public AtendimentoMapper()
        {
            Table("Atendimentos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.CanalId).Column("CanalId");
            Map(p => p.Protocolo).Column("Protocolo");
            Map(p => p.CampanhaId).Column("CampanhaId");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.FinalizadoPor).Column("FinalizadoPor");
            Map(p => p.FinalizadoEm).Column("FinalizadoEm");
        }
    }
}

