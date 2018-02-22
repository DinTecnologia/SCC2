using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class EntidadeSecaoAbaCampoDinamicoMapper : ClassMapper<EntidadeSecaoAbaCampoDinamico>
    {
        public EntidadeSecaoAbaCampoDinamicoMapper()
        {
            Table("EntidadeSecaoAbaCampoDinamicos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.CampoDinamicoId).Column("CampoDinamicoId");
            Map(p => p.EntidadeSecaoAbaId).Column("EntidadeSecaoAbaId");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
