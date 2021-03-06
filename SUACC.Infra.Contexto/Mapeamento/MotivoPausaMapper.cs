using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
   
    public  class MotivoPausaMapper : ClassMapper<MotivoPausa>
    {
        public MotivoPausaMapper()
        {
            Table("MotivoPausas");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.TempoEstimado).Column("TempoEstimado");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.Ativo).Column("Ativo");
        }

    }
}
