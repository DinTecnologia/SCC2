using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class EntidadeSecaoMapper : ClassMapper<EntidadeSecao>
    {
        public EntidadeSecaoMapper()
        {
            Table("EntidadeSecoes");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.EntidadeId).Column("Nome");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Ordem).Column("Nome");
            Map(p => p.Script).Column("Nome");
            Map(p => p.PadraoFerramenta).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.AtualizadoEm).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
