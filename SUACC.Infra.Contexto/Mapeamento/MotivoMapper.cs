using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class MotivoMapper : ClassMapper<Motivo>
    {
        public MotivoMapper()
        {
            Table("Motivos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.MotivoPaiId).Column("MotivoPaiId");
            Map(p => p.NomeExibicao).Column("NomeExibicao");
            Map(p => p.EstruturaIds).Column("EstruturaIds");
            Map(p => p.DependenteMotivoId).Column("DependenteMotivoId");
            Map(p => p.EntidadesIds).Column("EntidadesIds");
            Map(p => p.AtividadeTipoIds).Column("AtividadeTipoIds");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
        }
    }
}
