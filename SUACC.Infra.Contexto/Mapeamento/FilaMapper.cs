using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public  class FilaMapper : ClassMapper<Fila>
    {
        public FilaMapper()
        {
            Table("Filas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.CampanhaId).Column("CampanhaId");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.AtividadeTipoIds).Column("AtividadeTipoIds");
            Map(p => p.CanalTiposIds).Column("CanalTiposIds");
            Map(p => p.SlaFechamento).Column("SlaFechamento");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
