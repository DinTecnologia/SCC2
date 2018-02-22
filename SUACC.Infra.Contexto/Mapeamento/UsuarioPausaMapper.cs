using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public class UsuarioPausaMapper : ClassMapper<UsuarioPausa>
    {
        public UsuarioPausaMapper()
        {
            Table("UsuarioPausas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.MotivoPausaId).Column("MotivoPausaId");
            Map(p => p.UsuarioId).Column("UsuarioId");
            Map(p => p.CanalId).Column("CanalId");
            Map(p => p.IniciadoEm).Column("IniciadoEm");
            Map(p => p.FinalizadoEm).Column("FinalizadoEm");
            Map(p => p.Expirado).Column("Expirado");
        }

    }
}
