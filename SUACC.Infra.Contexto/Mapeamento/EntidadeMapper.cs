using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class EntidadeMapper : ClassMapper<Entidade>
    {
        public EntidadeMapper()
        {
            Table("Entidades");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.NomeLogico).Column("NomeLogico");
            Map(p => p.Script).Column("Script");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
