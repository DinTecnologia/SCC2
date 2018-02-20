using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AplicacaoMapper : ClassMapper<Aplicacao>
    {
        public AplicacaoMapper()
        {
            Table("Aplicacoes");            
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Url).Column("Url");
            Map(p => p.Ssl).Column("Ssl");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
