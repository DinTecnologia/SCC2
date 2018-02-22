using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class EntidadeSecaoAbaMapper : ClassMapper<EntidadeSecaoAba>
    {
        public EntidadeSecaoAbaMapper()
        {
            Table("EntidadeSecaoAbas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.EntidadeSecaoId).Column("EntidadeSecaoId");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Ordem).Column("Ordem");
            Map(p => p.Script).Column("Script");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
