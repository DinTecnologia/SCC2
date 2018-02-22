using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class UsuarioTelefoniaMapper : ClassMapper<UsuarioTelefonia>
    {
        public UsuarioTelefoniaMapper()
        {
            Table("UsuarioTelefonias");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Posicao).Column("Posicao");
            Map(p => p.LoginTelefonia).Column("LoginTelefonia");
            Map(p => p.Ramal).Column("Ramal");
            Map(p => p.Ativo).Column("Ativo");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.UsuarioId).Column("UsuarioId");
        }
    }
}
