using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class AspNetUserLoginMapper : ClassMapper<AspNetUserLogin>
    {
        public AspNetUserLoginMapper()
        {
            Table("AspNetUserLogins");
            Map(p => p.LoginProvider).Column("LoginProvider");
            Map(p => p.ProviderKey).Column("ProviderKey");
            Map(p => p.UserId).Column("UserId");
        }
    }
}
