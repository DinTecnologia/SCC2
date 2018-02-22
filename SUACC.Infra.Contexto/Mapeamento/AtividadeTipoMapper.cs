using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AtividadeTipoMapper : ClassMapper<AtividadeTipo>
    {
        public AtividadeTipoMapper()
        {
            Table("AtividadeTipos");
            Map(p => p.Id).Column("Id").Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
