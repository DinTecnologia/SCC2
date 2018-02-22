using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class CampoDinamicoOpcaoMapper : ClassMapper<CampoDinamicoOpcao>
    {
        public CampoDinamicoOpcaoMapper()
        {
            Table("CampoDinamicoOpcoes");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.CampoDinamicoId).Column("Nome");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Selecionado).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
