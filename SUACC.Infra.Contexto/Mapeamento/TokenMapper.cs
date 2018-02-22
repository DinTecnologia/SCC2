using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class TokenMapper : ClassMapper<Token>
    {
        public TokenMapper()
        {
            Table("Tokens");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.UtilizadoEm).Column("UtilizadoEm");
            Map(p => p.Acao).Column("Acao");
            Map(p => p.UsuarioId).Column("UsuarioId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.ExpiraEm).Column("ExpiraEm");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
