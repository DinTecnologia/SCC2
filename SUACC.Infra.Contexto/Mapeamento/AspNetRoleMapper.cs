using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AspNetRoleMapper : ClassMapper<AspNetRole>
    {
        public AspNetRoleMapper()
        {
            Table("AspNetRoles");
            Map(p => p.Id).Column("Id");
            Map(p => p.Name).Column("Nome");
        }
    }
}
