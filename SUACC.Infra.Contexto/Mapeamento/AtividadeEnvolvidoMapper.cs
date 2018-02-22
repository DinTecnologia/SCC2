using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public  class AtividadeEnvolvidoMapper : ClassMapper<AtividadeEnvolvido>
    {
        public AtividadeEnvolvidoMapper()
        {
            Table("AtividadeEnvolvidos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtividadeId).Column("AtividadeId");
            Map(p => p.ClienteId).Column("ClienteId");
            Map(p => p.UsuarioId).Column("UsuarioId");
            Map(p => p.Email).Column("Email");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Tipo).Column("Tipo");
            Map(p => p.Ordem).Column("Ordem");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
