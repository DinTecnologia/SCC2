using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AspNetUserClaimMapper : ClassMapper<AspNetUserClaim>
    {
        public AspNetUserClaimMapper()
        {
            Table("AspNetUserClaims");
            Map(p => p.Id).Column("Id");
            Map(p => p.UserId).Column("Nome");
            Map(p => p.ClaimType).Column("Nome");
            Map(p => p.ClaimValue).Column("Nome");
        }
    }
}
